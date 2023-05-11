
# pip install readkeys requests

from os import system, name
import readkeys
import requests

global_url = "https://api.miro.com/v2";
global_access_token = ""

def main():
    board_id = "uXjVMLoNNaA="

    key = ""
    while key != "x":
        clear()
        print("Miro API Client : Python")
        print()
        print("<1> Get Boards")
        print("<2> Create Board")
        print("<3> Get Board Ttems")
        print("<4> Create Shapes and Connectors")
        print("\n<X> EXIT")

        key = readkeys.getch()

        action = True
        match key.upper():
            case "1":
                boards = get_boards()
                print("\nBoards")
                for board in boards:
                    print(board["id"])

            case "2":
                data = {
                    "description": "Board Description",
                    "name": "Board Name"
                }                
                board = create_board(data)
                print("\nBoard")
                print(board["id"])

            case "3":
                boards = get_boards()
                print("\nBoards")
                for board in boards:
                    print(board["id"])

                print("\nBoard Id ? ", end = "")
                boardId = input()
                board_items = get_board_items(boardId)
                print("\nBoard Items")
                for item in board_items:
                    print(item["id"], item["type"])

            case "4":
                boards = get_boards()
                print("\nBoards")
                for board in boards:
                    print(board["id"])

                print("\nBoard Id ? ", end = "")
                boardId = input()

                # shapes

                data = {
                    "data": {
                        "shape": "rectangle"
                    },
                    "position": {
                        "origin": "center",
                        "x": -100,
                        "y": 0
                    },
                    "geometry": {
                        "height": 100,
                        "width": 100
                    }
                }
                shape_1 = create_board_shape(board_id, data)

                data = {
                    "data": {
                        "shape": "circle"
                    },
                    "position": {
                        "origin": "center",
                        "x": 100,
                        "y": 0
                    },
                    "geometry": {
                        "height": 100,
                        "width": 100
                    }
                }
                shape_2 = create_board_shape(board_id, data)

                data = {
                    "data": {
                        "shape": "triangle"
                    },
                    "position": {
                        "origin": "center",
                        "x": 0,
                        "y": 150
                    },
                    "geometry": {
                        "height": 100,
                        "width": 100
                    }
                }
                shape_3 = create_board_shape(board_id, data)

                print("\nShapes")
                print(shape_1["id"], shape_1["type"])
                print(shape_2["id"], shape_2["type"])
                print(shape_3["id"], shape_3["type"])
                
                # connectors

                data = {
                    "startItem": { "id": shape_1["id"] },
                    "endItem": { "id": shape_2["id"] }
                } 
                connector_12 = create_board_connector(board_id, data)

                data = {
                    "startItem": { "id": shape_2["id"] },
                    "endItem": { "id": shape_3["id"] }
                } 
                connector_23 = create_board_connector(board_id, data)

                print("\nConnectors")
                print(connector_12["id"])
                print(connector_23["id"])
 
            case _:
                action = False

        if action:
            print("\nPress ANY KEY...")
            readkeys.getch()

def clear():
    if name == 'nt':
        _ = system('cls')
    else:
        _ = system('clear')

# API Boards

def get_boards():
    url = f"{global_url}/boards"
    headers = {
        "Accept": "application/json",
        "Authorization": f"Bearer {global_access_token}"
    }
    response = requests.get(url, headers=headers)
    #print(response.text)
    boards = response.json().get("data")
    #print(boards)
    return boards

def create_board(data):
    url = f"{global_url}/boards"
    headers = {
        "Accept": "application/json",
        "Authorization": f"Bearer {global_access_token}",
        "Content-type": "application/json"
    }
    response = requests.post(url, headers=headers, json=data)
    #print(reponse.text)
    result = response.json()
    #print(result)
    return result

def get_board_items(board_id):
    url = f"{global_url}/boards/{board_id}/items"
    headers = {
        "Accept": "application/json",
        "Authorization": f"Bearer {global_access_token}"
    }
    response = requests.get(url, headers=headers)
    #print(response.text)
    result = response.json().get("data")
    #print(result)
    return result

def create_board_shape(board_id, data):
    url = f"{global_url}/boards/{board_id}/shapes"
    headers = {
        "Accept": "application/json",
        "Authorization": f"Bearer {global_access_token}",
        "Content-type": "application/json"
    }
    response = requests.post(url, headers=headers, json=data)
    #print(response.text)
    result = response.json()
    #print(result)
    return result

def create_board_connector(board_id, data):
    url = f"{global_url}/boards/{board_id}/connectors"
    headers = {
        "Accept": "application/json",
        "Authorization": f"Bearer {global_access_token}",
        "Content-Type": "application/json"
    }
    response = requests.post(url, headers=headers, json=data)
    #print(response.text)
    result = response.json()
    #print(result)
    return result
    
if __name__=='__main__':
    main()
