import requests, json, sys, os, base64

url = "http://localhost:8080"
headers = {'Content-Type': 'application/json'}

def signup(username, password):
    data = {
        "username": username,
        "password": base64.b64encode(password.encode("ascii")),
    }
    r = requests.post(url + "/signup", headers=headers, data=json.dumps(data))
    return r

def login(username, password):
    data = {
        "username": username,
        "password": base64.b64encode(password.encode("ascii")),
    }
    r = requests.post(url + "/login", headers=headers, data=json.dumps(data))
    return r

def main():
    signup("admin", "admin")
    login("admin", "admin")

if __name__ == "__main__":
    main()
