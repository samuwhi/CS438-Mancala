from comm import get_game_state, put_move

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

def main():
    # get board
    board, turn = get_game_state()

    for i in range(1, len(board[0])):
        if legal(board, turn, i):
            print('Checking move', i)
            put_move(i)
            break

if __name__ == "__main__":
    main()