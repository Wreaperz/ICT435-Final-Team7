#python program to parse packets
#Source: https://www.uv.mx/personal/angelperez/files/2018/10/sniffers_texto.pdf#:~:text=Packet%20sniffer%20in%20Python%20A%20simple%20packet%20sniffer,to%20the%20underlying%20protocols%2C%20which%20support%20socket%20abstractions.

from struct import *
import sys
import socket


def ethernet_head(raw_data): 
	dest, src, prototype = struct.unpack('! 6s 6s H', raw_data[:14]) 
	dest_mac = get_mac_addr(dest) 
	src_mac = get_mac_addr(src) 
	proto = socket.htons(prototype) 
	data = raw_data[14:] 
	return dest_mac, src_mac, proto, data

	def main():
		s = socket.socket(socket.AF_PACKET, socket.SOCK_RAW, socket.ntohs(3))
		while True:
			raw_data, addr = f_contents
			eth = ethernet(raw_data)
			print('\nEthernet Frame:')
			print('Destination: {}, Source: {}, Protocol: {}'.format(eth[0], eth[1], eth[2]))
	main()
ethernet_head()
