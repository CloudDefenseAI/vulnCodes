import requests, sys, os, json, re

def main():
    filename = input("Enter the filename to open it: ")
    print("Opening file: " + filename)
    if re.search(r'[^a-zA-Z0-9_]', filename):
        print("[-] Invalid filename, please check the filename and try again")
        sys.exit(1)
    output = os.popen("cat " + filename+".jpeg").read()
    print(output)

if __name__ == "__main__":
    main()
