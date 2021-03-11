sudoku = [list(map(int, input().split())) for _ in range(9)]

zeros = [(n, m) for n in range(9) for m in range(9) if sudoku[n][m] == 0]


def pruning(a, b):
    promising = [1, 2, 3, 4, 5, 6, 7, 8, 9]

    for i in range(9):
        if sudoku[i][b] in promising:
            promising.remove(sudoku[i][b])
        if sudoku[a][i] in promising:
            promising.remove(sudoku[a][i])
    a //= 3
    b //= 3

    for p in range(3):
        for q in range(3):
            if sudoku[p + (3*a)][q + (3*b)] in promising:
                promising.remove(sudoku[p + (3*a)][q + (3*b)])

    return promising


flag = False


def codes(depth):
    global flag
    if flag:
        return
    if depth == len(zeros):
        for row in sudoku:  # 세로 크기
            print(*row)
        flag = True
        return
    else:
        (i, j) = zeros[depth]
        promising = pruning(i, j)
        for k in promising:
            sudoku[i][j] = k
            codes(depth + 1)
            sudoku[i][j] = 0

codes(0)
