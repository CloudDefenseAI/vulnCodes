import os
import sys
import json
import requests

data = { "username": "admin", "password": "admin" }
cookies = { "JSESSIONID": "1234567890" }
headers = { "Content-Type": "application/json" }
url = "https://website.com/login"

def main():
    r = requests.post(url, data=json.dumps(data), headers=headers, cookies=cookies)
    if r.status_code == 200:
        print("Login successful")
    else:
        print("Login failed")

if __name__ == "__main__":
    main()
    
