#!usr/bin/python
#Source code from: https://www.bitforestinfo.com/blog/02/15/how-to-write-simple-packet-sniffer.html
import socket
import struct
import binascii
import os
import pye



with open(file_path, 'rb') as f:
    pkt = f.read()
    print(pkt)
#extract packets with pye unpack 
unpack=pye.unpack()
#print data to terminal
print ("\n\n==&gt;&gt; [+] ----------Ethernet Header---- [+]")
for i in unpack.eth_header(pkt[0][0:14]).iteritems():
	a,b=i 
	print ("{} : {} | ".format(a,b),)
print ("\n===&gt;&gt; [+] ----------IP Header---- [+]")	
for i in unpack.ip_header(pkt[0][14:34]).iteritmes():
	a,b=i
	print ("{} : {} | ".format(a,b),)
print ("\n===&gt;&gt; [+] ----------TCP Header---- [+]")
for i in unpack.tcp_header(pkt[0][34:54]).iteritems():
	a,b=i
	print ("{} : {} | ".format(a,b),)
