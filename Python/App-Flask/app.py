
# pip install flask flask_cors

from datetime import datetime, timedelta
from flask import Flask, redirect, request, render_template
from flask_cors import CORS
import json
import requests

global_base_url = "https://api.miro.com/v2"
global_redirect_uri = "https://miro.com/app-install-completed"
global_redirect_uri_app = "http://localhost:3000/redirect"
global_client_id = ""
global_client_secret = ""

global_access_token = ""
global_refresh_token = ""
global_expire_date_time = datetime.now()
global_team_id = ""

global_log = True
#global_log = False

app = Flask(__name__)
CORS(app)

# App

@app.route("/")
def home():
    print_log("/")
    return render_template("home.html")

@app.route("/miro")
def miro():
    print_log("/miro")
    return render_template("miro.html")

# OAuth

# {
#     "user_id": "9876543210123456789",
#     "refresh_token": "eyJtaXJvLm9yaWdpbiI6ImV1MDEifQ_-PIBKmE9rzQuL3bUeAvUEGFEhLk",
#     "access_token": "eyJtaXJvLm9yaWdpbiI6ImV1MDEifQ_o-P91OccaII0A63CDSK--x21xiI",
#     "expires_in": 3599,
#     "team_id": "1234567890987654321",
#     "scope": "boards:write boards:read",
#     "token_type": "bearer"
# }

@app.route("/redirect", methods=["GET", "POST"])
def oauth_redirect():
    print_log("/redirect")
    authentication_code = request.args.get("code", default="", type=str)
    token = oauth_token(authentication_code)

    print_log(f"{global_access_token} | {global_refresh_token} | {global_expire_date_time} | {global_team_id}")

    redirect_uri = f"{global_redirect_uri}?" + \
        f"client_id={global_client_id}" + \
        f"&team_id={global_team_id}"
    return redirect(redirect_uri)

# Miro calls /authorize autimatically after authentication Web SDK.
# This method is only for testing purposes.
@app.route("/redirect/authorize", methods=["GET", "POST"])
def oauth_authorize():
    print_log("/authorize")
    url = "https://miro.com/oauth/authorize?" + \
        "response_type=code" + \
        f"&client_id={global_client_id}" + \
        f"&redirect_uri={global_redirect_uri_app}"    
    headers = {
        "Accept": "application/json"
    }
    print_log(url)
    return redirect(url)

# This method is only for testing purposes.
@app.route("/redirect/status", methods=["GET"])
def status():
    print_log("/status")
    return f"""Access Token : {global_access_token}
<br />Refresh Token : {global_refresh_token}
<br />Expire Date/Time : {global_expire_date_time}
<br />Team ID : {global_team_id}"""

# API Miro

def oauth_token(authorization_code):   
    print_log("oauth_token")
    url = "https://api.miro.com/v1/oauth/token?" + \
        "grant_type=authorization_code" + \
        f"&client_id={global_client_id}" + \
        f"&client_secret={global_client_secret}" + \
        f"&code={authorization_code}" + \
        f"&redirect_uri={global_redirect_uri_app}"
    headers = {
        "Accept": "application/json"
    }
    response = requests.post(url, headers=headers)
    print_log(response.text)
    token = response.json()
    oauth_save_token(token)
    return token

def oauth_refresh():   
    print_log("oauth_refresh")
    url = "https://api.miro.com/v1/oauth/token?" + \
        "grant_type=refresh_token" + \
        f"&client_id={global_client_id}" + \
        f"&client_secret={global_client_secret}" + \
        f"&refresh_token={global_refresh_token}"
    headers = {
        "Accept": "application/json"
    }
    response = requests.post(url, headers=headers)
    print_log(response.text)
    token = response.json()
    oauth_save(token)
    return token

def oauth_save_token(token):
    print_log("oauth_save_token")
    global global_access_token
    global global_refresh_token
    global global_expire_date_time
    global global_team_id
    if token is not None:
        global_access_token = token.get("access_token")
        global_refresh_token = token.get("refresh_token")
        expires_in = token.get("expires_in")
        if expires_in is None:
            expires_in = 0        
        global_expire_date_time = datetime.now() + timedelta(seconds=expires_in)
        global_team_id = token.get("team_id")
    else:
        global_access_token = ""
        global_refresh_token = ""
        global_expire_date_time = datetime.now()
        global_team_id = ""

# ...

def print_log(message):
    if global_log and message is not None:
        print()
        if isinstance(message, str):
            if message[0:1] == "{":
                print(message)
            else:
                print(message[0:100])
        else:
            print(json.dumps(message))

if __name__ == "__main__":
    app.run(debug=True)
