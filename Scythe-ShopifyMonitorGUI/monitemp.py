from datetime import datetime
import urllib3,os,time,json,traceback,cloudscraper,sys,socket,pickle,discord

class kwdstr:
        def __init__(self, kwd, skul):
            self.kwd = kwd
            self.skul = skul

class sndfrm:
    def __init__(self, embed, val, footTxt, hp):
            self.embed = embed
            self.val = val
            self.footTxt = footTxt
            self.hp = hp

proxnum = 0
monistart = 1

kwdlst = list()
clsesh = list()
INSTOCK = list()
titles = list()

oldhtml = ""
prxMaster = ''
mainPrx = {"http": prxMaster, "https": prxMaster} 
dir = 'C:\\xbox\\sneaker-monitors\\'

if len(sys.argv) == 0:
    print("didnt pick up any sys args!\nquitting...",flush=True)
    exit()

delay = float(sys.argv[2])
resetA =float(sys.argv[3])
indexA =float(sys.argv[4])

with os.scandir(f'{dir}sLs\\') as entries:
    for entry in entries:
        if '-' not in entry.name:
            kwdlst.append(kwdstr(entry.name.replace('.txt',''),open(f'{dir}sLs\\{entry.name}', "r").read()))
        else:
            for item in entry.name.replace('.txt','').split('-'):
                kwdlst.append(kwdstr(item,open(f'{dir}sLs\\{entry.name}', "r").read()))

prxies = open(f'{dir}proxies.txt', "r").read().split('\n')


for i in range(len(prxies)):
    scraper = cloudscraper.create_scraper(
        browser={
            'browser': 'chrome',
            'platform': 'windows',
            'mobile': False
        }
    )
    clsesh.append(scraper)

usrSite = f'{sys.argv[1].strip()}/products.json'
    
def check_url(url):
    return 'products.json' in url

def scrape_site(url, proxy):
    items = []
    global oldhtml
    
    scrapes = 0
    while True:
        scrapes+=1

        erc = False
        crc = False
        html = None
        output = None
        
        prxMaster = 'http://' + prxies[proxnum]
        mainPrx = {"http": prxMaster, "https": prxMaster}

        try:
            hh = clsesh[proxnum].get(f'http://{url}?page=1&limit={indexA}', proxies=mainPrx)
            html = hh.text
            
        except Exception as e:
            print(f"site info wonky:\n   Prxy: {prxies[proxnum]}    Site: {usrSite}\n",flush=True)
            erc = True
        
        if  scrapes > resetA:
                clsesh[proxnum].cookies.clear_session_cookies()
                proxchange()
                scrapes = 0

        if erc == False:
            try:
                output = json.loads(html)['products']
            except:
                if hh.status_code != 401:
                    print(f"{hh.status_code} json err:\n   Prxy: {prxies[proxnum]}   Site: {usrSite}\n",flush=True)
                    crc = True

            if crc == False:
                htmltxt = html
                
                if oldhtml == htmltxt:
                    time.sleep(delay)
                    pass
                else:
                    print('change ' + url + ' ' + str(datetime.now()) + "\n",flush=True)
                    # Stores particular details in array
                    for product in output:
                        try:
                            product_item = {
                                'title': product['title'], 
                                'image': product['images'][0]['src'], 
                                'handle': product['handle'],
                                'variants': product['variants']} 
                        except:
                            product_item = {
                                'title': product['title'], 
                                'image': None, 
                                'handle': product['handle'],
                                'variants': product['variants']}
                        items.append(product_item)
                        oldhtml = htmltxt
                    return items

def proxchange():
    global prxMaster
    global proxnum
    global mainPrx
    if prxies != []:
        try:
            if proxnum == (len(prxies)-1):
                proxnum = 0
            else:
                proxnum += 1
            
        except:
            print("bruh moment exception",flush=True)
            exit()
    return 

def checker(item):
    return item in INSTOCK


def discord_webhook(title, url, thumbnail, sizes, price, hp):
    fields = []
    val = list()
    for size in sizes:
        val.append(size['url']) 
    footUrl = usrSite.replace('.json', '/') + url
    footTxt = "{}".format(footUrl)
    embedVar = discord.Embed()
    embedVar.set_author(name=usrSite, icon_url="https://static.wikia.nocookie.net/runescape2/images/f/f2/Scythe_detail.png")
    embedVar.title = title
    embedVar.color = 0x6f00ff
    embedVar.url = 'https://' + usrSite.replace('.json', '/') + url
    embedVar.set_thumbnail(url=thumbnail)
    embedVar.add_field(name="PRICE", value=str(price), inline=False)

    sendProdInfo(sndfrm(embedVar,val,footTxt, hp))
    
    print("lets go it worked",flush=True)

def sendProdInfo(embed):
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    server_address = ('localhost', 10000)
    sock.connect(server_address)
    SbytEmbed = pickle.dumps(embed)

    try:
        sock.sendall(SbytEmbed)

    finally:
        sock.close()


def comparitor(product, monistart, hp):
    product_item = [product['title'], product['image'], product['handle']]
    available_sizes = []
    price = None
    for size in product['variants']:
        price = size['price']
        if size['available']:
            try:
                title = ""
                opt1 = size['option1']
                opt2 = size['option2']
                if opt2 != None:
                    if len(opt2) <= len(opt1) and '-' not in opt2:
                        title = opt2
                    else:
                        if '-' in opt1:
                            title = opt2
                        else:
                            title = opt1
                else:
                    title = size['title']
                if title != "default":
                    available_sizes.append({'url': title, 'inline': False})
            except:
                print(traceback.format_exc(),flush=True)
            

    product_item.append(available_sizes) 

    if available_sizes:
        if not checker(product_item):
            #### If product is available but not stored - sends notification and stores
            INSTOCK.append(product_item)
            if monistart == 0:
                
                print("sending webhook func data",flush=True)
                discord_webhook(
                    title=product['title'],
                    url=product['handle'],
                    thumbnail=product['image'],
                    sizes=available_sizes,
                    price=price,
                    hp = hp
                )
                titles.append(product['handle'])         

    else:
        if product['handle'] in titles:
            if monistart == 0:
                print("sending oos prod!",flush=True)
                discord_webhook(
                    title=product['title'],
                    url=product['handle'],
                    thumbnail=product['image'],
                    sizes=available_sizes,
                    price=price,
                    hp = hp
                )
                print('sent oos disc noti',flush=True)
                titles.remove(product['handle'])
            print("item oos",flush=True)
        


def monitor():
    global proxnum
    global mainPrx
    global prxMaster
    
    global monistart
    print(f'''\n{usrSite} running...\n''',flush=True)

    if not check_url(usrSite):
        print('url format is dumb',flush=True)
        return

    while True:
        try:
            items = scrape_site(usrSite, mainPrx,)
            for product in items:

                brek = False
                hp = False

                for index,item in enumerate(kwdlst):

                    if 'Badge_Pickup Raffle'.lower() in str(product).lower():
                        break
                    
                    if item.kwd.lower() in product['title'].lower():
                        
                        if 'dunk' in item.kwd.lower() and 'sb' in product['title'].lower():
                            hp = True
                            comparitor(product, monistart, hp)
                            brek = True
                            break
                        
                        for sku in item.skul.split('\n'):
                            if sku.lower() in str(product).lower():
                                hp = True

                                comparitor(product, monistart, hp)
                                brek = True
                                break
                        
                        if brek==False:
                            comparitor(product, monistart, hp)

                        break

            monistart = 0

        # Rotates proxies upon rq exception
        except cloudscraper.exceptions.RequestException as e:
            print(e,flush=True)

            if prxies != []:
                try:
                    if proxnum == (len(prxies)-1):
                        proxnum = 0
                    else:
                        proxnum += 1
                        #print('switching to proxy: ' + prxies[proxnum],flush=True)
                except:
                    print("fatal exception while rotating proxies after request exception\nQuiting...",flush=True)
                    exit()
    

        except Exception as e:
            print(f"exception found: {traceback.format_exc()}",flush=True)
            print('proxy: ' + prxies[proxnum] + '\n',flush=True)
            if prxies != []:
                try:
                    if proxnum == (len(prxies)-1):
                        proxnum = 0
                    else:
                        proxnum += 1
                except:
                    print(f"{e}\nfatal exception while rotating proxies after exception\nQuiting...",flush=True)
                    exit()


urllib3.disable_warnings()
monitor()