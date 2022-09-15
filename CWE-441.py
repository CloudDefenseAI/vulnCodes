import requests
import sys
import os
import json

def main():
    url = sys.argv[1]
    print(url)
    response = requests.get(url)
    print(response.text)

if __name__ == "__main__":
    main()
