import requests
import sys
import os

def main():
    if len(sys.argv) != 3:
        print("Usage: %s <url> <file>" % sys.argv[0])
        sys.exit(1)

    url = sys.argv[1]
    filename = sys.argv[2]

    filename = os.path.basename(filename)
    filename = filename.replace("../", "")
    filename = filename.replace("..\\", "")
    filename = filename.replace("%2e%2e%2f", "")
    filename = filename.replace("%2e%2e%5c", "")

    if not os.path.exists(filename):
        print("File %s does not exist" % filename)
        sys.exit(1)
    
    with open(filename) as f:
        data = f.read()

    r = requests.post(url, data=data)
    print(r.text)

if __name__ == "__main__":
    main()
