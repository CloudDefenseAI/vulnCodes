import requests
import json
import base64

## Login simple user but not admin!
received_data = "eyJpZCI6MSwibmFtZSI6IlJvaGl0Iiwicm9sZSI6ImFkbWluIn0="
received_data = received_data.encode("ascii")
received_data = base64.b64decode(received_data)
if received_data:
    received_data = json.loads(received_data)
    if received_data["role"] == "user":
        print("You are User, you have low privilleges")
    else:
        print("You are admin, you can access everything!")
