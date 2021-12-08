# ip2location.py
# Programmer: Caleb Carpenter
# Source: https://www.abstractapi.com/guides/how-to-geolocate-an-ip-address-in-python

# Imports
import requests
import json
import argparse
import sys
import os

# API Key for Program
my_api_key = "2efadf35d88447b5b2dfe6410841db2f"
# IP address to test
addr = sys.argv[1]
# Int that denotes what Fields to Use
usedFields = int(sys.argv[2])


# ------------------ PROGRAM ----------------------#
# Send URL request
response = requests.get('https://ipgeolocation.abstractapi.com/v1/?api_key=' + my_api_key + '&ip_address=' + addr)

# Get Response in JSON Format
json_data = json.loads(response.content)

#json_formatted_str = json.dumps(json_data, indent=2)
#print(json_formatted_str)
# Print Response Code
#print("Response Code: ", response.status_code, "\n")

# Parse JSON-Formatted Data
city = json_data['city']
region = json_data['region']
country = json_data['country']
long = json_data['longitude']
lat = json_data['latitude']
org = json_data['connection']['organization_name']
isp = json_data['connection']['isp_name']

# List of all Active Fields (Features to be used in PACMAN Standalone)
activeFields = [city, region, country, long, lat, org, isp]

# --- LOGIC ---
    # PACMAN App sends in Code from DropDown Box to Tell IP2Location WHAT fields to use
    # IP2Loc looks at Code and decides what fields to use
    # 0 = ALL
    # 1 = City
    # 2 = Region
    # 3 = Country
    # 4 = Latitude and Longitude
    # 5 = Organization Name
    # 6 = ISP
# -------------

fields = ""
if (usedFields == 0):
    count = 0
    while count <= 6:
        if(count != 6):
            fields += str(activeFields[count]) + "|"
        else:
            fields += str(activeFields[count])
        count += 1
elif (usedFields == 4):
    fields = str(activeFields[4]) + "| " + str(activeFields[3])
elif (usedFields == 5 or usedFields == 6):
    fields = activeFields[usedFields]
else:
    fields = activeFields[usedFields-1]

print(fields)
