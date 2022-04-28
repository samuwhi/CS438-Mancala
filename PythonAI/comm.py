MOVEFILE = "move.txt"
BOARDFILE = "board.txt"


def get_game_state():
    board = []
    turn = None
    with open(BOARDFILE, "r") as f:
        row1 = [int(x) for x in f.readline().split()]
        row2 = [int(x) for x in f.readline().split()]
        turn = int(f.readline())
    board.append(row1)
    board.append(row2)

    return board, turn

def put_move(move):
    with open(MOVEFILE, "w") as f:
        f.write(str(move))

