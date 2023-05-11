
from flask import Flask, request, render_template
from flask_cors import CORS
import json

app = Flask(__name__)
CORS(app) # !

# APP

@app.route("/")
def home():
   return render_template("home.html")

# Miro

@app.route("/miro")
def miro():
   return render_template("miro.html")

# API

# GET /echo
@app.route("/echo", methods=["GET"])
def echo():
    # {"a":"1","b":"2","c":"3"}
    print(request.args)
    #app.logger.info(request.args)
    #app.logger.info(request.json)
    #app.logger.info(request.form)
    return request.args

if __name__ == "__main__":
    app.run(debug=True)
