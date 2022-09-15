import requests, sys, os, json

def main():
    filename = input("Enter the filename to open it: ")
    print("Opening file: " + filename)
    output = os.popen("cat " + filename+".jpeg").read()
    print(output)

if __name__ == "__main__":
    main()
