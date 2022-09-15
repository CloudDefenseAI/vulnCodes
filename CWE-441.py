import requests
import sys
import os
import json

def main():
    url = sys.argv[1]
    allowedDomains = ["https://www.website.com", "https://website.com", "https://internal.website.com"]
    if url.startswith(tuple(allowedDomains)):
        print(url)
        response = requests.get(url)
        print(response.text)
    else:
        print("Invalid URL")

if __name__ == "__main__":
    main()
