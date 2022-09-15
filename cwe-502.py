import requests
import json
import base64

## Login simple user but not admin!
received_data = "eyJpZCI6MSwibmFtZSI6IlJvaGl0Iiwicm9sZSI6ImFkbWluIn0="
if received_data:
    received_data = json.loads(received_data)
    if received_data["role"] == "user":
        print("You are User, you have low privilleges")
    elif received_data["role"] == "admin":
        print("You can't access admin panel from this link, you altered data!")
    else:
        print("You are User, you have low privilleges")
