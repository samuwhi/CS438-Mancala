from pprint import pprint
import sys

def get_game_state():
    board = []
    turn = None
    with open("board.txt", "r") as f:
        row1 = [int(x) for x in f.readline().split()]
        row2 = [int(x) for x in f.readline().split()]
        turn = int(f.readline())
    board.append(row1)
    board.append(row2)

    return board, turn

def put_move(move):
    with open("move.txt", "w") as f:
        f.write(str(move))
    sys.exit()  

def legal(board, turn, move):
    tmp = None
    if move < 0 or move > 6:
        return False

    if turn == 0:
        tmp = 7 - move
    else:
        tmp = move - 1
    
    if board[turn][tmp] == 0:
        return False

    return True

# get board
board, turn = get_game_state()
for i in range(len(board[0]) - 1, 0, -1):
    if legal(board, turn, i):
        put_move(i)

