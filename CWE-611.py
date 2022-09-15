import requests
import sys
import os
import json
import xml

def main():
    payload = sys.argv[1]
    """
    user can provide below value as payload to trigger XXE attack
    <?xml version="1.0" encoding="UTF-8"?>
    <!DOCTYPE foo [<!ELEMENT foo ANY >
    <!ENTITY xxe SYSTEM "file:///etc/passwd" >]>
    <root>
    <name>&xxe;</name>
    </root>
    """
    headers = {
        "Content-Type": "application/xml"
    }
    ## first check payload for XXE
    if payload.find("DOCTYPE") != -1:
        print("XXE attack detected")
        sys.exit(1)

    if payload.find("ENTITY") != -1:
        print("XXE attack detected")
        sys.exit(1)
    
    r = requests.post("https://api.website.com/data.php", data=payload, headers=headers)
    print(r.text)
    
if __name__ == "__main__":
    main()
