# ScapySkeletonV5.py
# ICT 435 Final Project - Team 7
# Team: Ashley Godinez, Caleb Carpenter, Isai Rocha, Lucio Rubio, Taylor Antonich


# Imports
import argparse
import os
import sys
import scapy
from scapy.all import *



# File_name (the name of the PCAP file)
default_name = "default.pcap"

# Print Len and then List CLI arguments
# print(len(sys.argv))
# print(str(sys.argv))

# REQUIRED CLI Arguments (filename, IPs, and Ports)
file_name = sys.argv[1]
if(file_name == ""):
    file_name = default_name

srcIP = sys.argv[2]
dstIP = sys.argv[3]
srcPort = sys.argv[4]
dstPort = sys.argv[5]

# Optional CLI Arguments
if(len(sys.argv) > 6):
    srcMAC = sys.argv[6]
if(len(sys.argv) > 7):
    dstMAC = sys.argv[7]

# Process_PCAP - Evaluates PCAP file (from name) based on specific arguments and other functions
def process_pcap(file_name):
    print('Opening {}...'.format(file_name))

    srcIPHit = 0
    dstIPHit = 0
    srcPortHit = 0
    dstPortHit = 0
    srcMACHit = 0
    dstMACHit = 0

    srcIPBool = False
    dstIPBool = False
    srcPortBool = False
    dstPortBool = False

    # Original Settings (hardcoded values)
    # client = '192.168.1.137:46324'
    # server = '172.217.166.100:443'
    
    # New Settings (dynamic)
    client = srcIP + ":" + srcPort
    server = dstIP + ":" + dstPort

    (client_ip, client_port) = client.split(':')
    (server_ip, server_port) = server.split(':')
    
    count = 0
    perfect_match_count = 0
    
    for (pkt_data, pkt_metadata,) in RawPcapReader(file_name):
        count += 1
        
        ether_pkt = Ether(pkt_data)
        if 'type' not in ether_pkt.fields:
            # LLC frames will have 'len' instead of 'type'.
            # We disregard those
            continue

        if ether_pkt.type != 0x0800:
            # disregard non-IPv4 packets
            continue

        ip_pkt = ether_pkt[IP]
        
        if ip_pkt.proto != 6:
            # Ignore non-TCP packet
            continue

        if (ip_pkt.src != server_ip) and (ip_pkt.src != client_ip):
            # Uninteresting source IP address            
            srcIPHit += 1
            srcIPBool = True

        
        if (ip_pkt.dst != server_ip) and (ip_pkt.dst != client_ip):
            # Uninteresting destination IP address
            dstIPHit += 1
            if(srcIPBool == True):
                dstIPBool = True
            else:
                srcIPBool = False
                dstIPBool = False
                srcPortBool = False
                dstPortBool = False

        tcp_pkt = ip_pkt[TCP]
        
        if (tcp_pkt.sport != int(server_port)) and \
           (tcp_pkt.sport != int(client_port)):
            # Uninteresting source TCP port
            srcPortHit += 1
            if(srcIPBool == True and dstIPBool == True):
                srcPortBool = True
            else:
                srcIPBool = False
                dstIPBool = False
                srcPortBool = False
                dstPortBool = False
        
        if (tcp_pkt.dport != int(server_port)) and \
           (tcp_pkt.dport != int(client_port)):
            # Uninteresting destination TCP port
            dstPortHit += 1
            if(srcIPBool == True and dstIPBool == True and srcPortBool == True):
                dstPortBool = True
            else:
                srcIPBool = False
                dstIPBool = False
                srcPortBool = False
                dstPortBool = False

        if(srcIPBool == True and dstIPBool == True and srcPortBool == True and dstPortBool == True):
            perfect_match_count += 1            

    print('{} contains {} packets ({} SRC IP Hits {} DST IP Hits {} SRC Port Hits {} DST Port Hits)'.
          format(file_name, count, srcIPHit, dstIPHit, srcPortHit, dstPortHit))

    print("\nPerfect Matches: " + str(perfect_match_count))

process_pcap(file_name)
sys.exit(0)
