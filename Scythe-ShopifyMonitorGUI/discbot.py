from discord.ext import tasks
from datetime import datetime
import threading, socket, pickle, sys, discord,traceback

class sndfrm:
    def __init__(self, embed, val, footTxt, hp):
            self.embed = embed
            self.val = val
            self.footTxt = footTxt
            self.hp = hp

class zmsgs:
    def __init__(self, msg, time, item, mStock):
            self.msg = msg
            self.time = time
            self.item = item
            self.mStock = mStock

class channelSend:
    def __init__(self,channel,message):
        self.channel = channel
        self.message = message
        
class sockThread(threading.Thread):
    def __init__(self, thread_name, thread_ID, state):
        threading.Thread.__init__(self)
        self.thread_name = thread_name
        self.thread_ID = thread_ID
        self.state = state

    def run(self):
        if self.state:
            handle_message()

        sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        server_address = ('localhost', 10000)
        sock.bind(server_address)

        sock.listen(1)
        while True:
            connection, client_address = sock.accept()

            connection_thread = threading.Thread(
                target=handle_connection, args=(connection, client_address))

            connection_thread.start()
        
def handle_message():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    server_address = ('localhost', 10001)
    sock.bind(server_address)

    sock.listen(1)
    while True:
        connection, client_address = sock.accept()

        try:
            while True:
                data = connection.recv(4096)
                if data:
                    msg = pickle.loads(data)
                    clientMsgs.append(msg)
                else:
                    break
        finally:
            connection.close()

def handle_connection(connection, client_address):
    try:
        while True:
            data = connection.recv(4096)
            if data:
                prod = pickle.loads(data)
                prds.append(prod)
            else:
                break
    finally:
        connection.close()
 
msgs = list()
prds = list()
clientMsgs = list()

TOKEN = sys.argv[1]
client = discord.Client(intents=discord.Intents.all())


@client.event
async def on_ready():
    pass
    await client.wait_until_ready()
    sender.start()

@tasks.loop(seconds=.1)
async def sender():
    msg = None
    mCheck = False
    
    for item in clientMsgs:
        channel = client.get_channel(item.channel)
        
        await channel.send(item.message)
        print(f'Discord Bot: sent msg \'{item.message}\' to \'{channel.name}\',\'{channel.guild.name}\'',flush=True)
        clientMsgs.remove(item)

    for item in prds:
        channel = client.get_channel(int(sys.argv[3]))
        nnn = "Low Priority"
        if item.hp == True:
            channel = client.get_channel(int(sys.argv[2]))
            nnn = "High Priority"
        for wbhk in msgs:
            if wbhk.item.title == item.embed.title:
                mCheck = True
                curstock = ""
                eEmb = wbhk.item
                for i in range(len(wbhk.mStock)):
                    if wbhk.mStock[i] not in item.val:
                        curstock += ("~~" + wbhk.mStock[i] + "~~" + "\n")
                for i in range(len(item.val)):
                    curstock += item.val[i] + "\n"    
                eEmb.set_field_at(index=1,name="STOCK",value=curstock)
                eEmb.set_footer(text = f"{nnn}  scvthe V1 --- {wbhk.time.strftime('%H:%M:%S')}  Edited at: {datetime.now().strftime('%H:%M:%S')}")
                try:
                    await wbhk.msg.edit(embed=eEmb)
                except:
                    traceback.print_exc()
                break

        if mCheck == False and len(item.val) != 0:
            sEmb = item.embed
            stock = ""
            for i in item.val:
                stock += f"{i} \n"
            sEmb.add_field(name="STOCK", value=stock, inline=False)
            sEmb.add_field(name="LINK", value=item.footTxt, inline=False)
            sEmb.set_footer(text=f"{nnn}  scvthe V1 --- " + datetime.now().strftime('%H:%M:%S'))
            try:
                msg = await channel.send(embed=sEmb)
            except:
                traceback.print_exc()
            msgs.append(zmsgs(msg,datetime.strptime(datetime.now().strftime('%H:%M:%S'), "%H:%M:%S"),item.embed,item.val))

        prds.remove(item)

    for wbhk in msgs:
        if (datetime.strptime(datetime.now().strftime('%H:%M:%S'), "%H:%M:%S") - wbhk.time).total_seconds() > 300:
            embed = wbhk.item
            embed.color = 0xffffff
            await wbhk.msg.edit(embed=embed)
            msgs.remove(wbhk)
    

x = sockThread("sockOne",1000,False)
x.start()

y = sockThread("sockTwo",2000,True)
y.start()

client.run(TOKEN)