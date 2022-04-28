import random, sys

def get_game_state():
    board = []
    turn = None

    f = open("Board.txt", "r")
    
    row1 = [int(x) for x in f.readline().split()]
    row2 = [int(x) for x in f.readline().split()]
    turn = int(f.readline())
    f.close()
    board.append(row1)
    board.append(row2)


    return board, turn

def put_move(move):
    f = open("move.txt", "x")
    sys.exit() 


while True:
    print('Hello')
put_move(random.randint(1,6))

