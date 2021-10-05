#program from https://www.bitforestinfo.com/blog/02/15/how-to-write-simple-packet-sniffer.html
from struct import *
import socket
import binascii


file_path = '/home/irocha4/ICT435/wiresharkfile.pcap'

with open(file_path, 'rb') as f:
    storeobj = f.read()
    #print(raw_data)

storeobjTuple=unpack("!6s6sH",storeobj[:14])
print(storeobjTuple[0])
#print(unpack("!6s6sH",storeobj[:14]))


#Ethernet Header
#def eth_header(data): #self, data
#	storeobj=data
#	storeobj=struct.unpack("!6s6sH",storeobj)
#	destination_mac=binascii.hexlify(storeobj[0])
#	source_mac=binascii.hexlify(storeobj[1])
#	eth_protocol=storeobj[2]
#	data={"Destination Mac":destination_mac,
#	"Source Mac":source_mac,
#	"Protocol":eth_protocol}
#	return destination_mac
#	print(storeobj)


#def ethernet_head(raw_data): 
#	dest, src, prototype = struct.unpack('! 6s 6s H', raw_data[:14]) 
#	dest_mac = get_mac_addr(dest) 
#	src_mac = get_mac_addr(src) 
#	proto = socket.htons(prototype) 
#	data = raw_data[14:] 
#	return dest_mac, src_mac, proto, data
#	print(dest_mac, src,_mac)
