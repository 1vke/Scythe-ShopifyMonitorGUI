import socket,pickle,sys

class channelSend:
    def __init__(self,channel,message):
        self.channel = channel
        self.message = message

def send():
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    server_address = ('localhost', 10001)
    sock.connect(server_address)

    #Sbytmsg = pickle.dumps(channelSend(int(id),message))
    Sbytmsg = pickle.dumps(channelSend(int(sys.argv[1]),sys.argv[2]))
    
    try:
        sock.sendall(Sbytmsg)

    finally:
        sock.close()
        print("sent",flush=True)

send()