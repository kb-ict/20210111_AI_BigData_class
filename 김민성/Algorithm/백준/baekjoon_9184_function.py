import sys
input = sys.stdin.readline

def dp(x, y, z):
    arr = [[[1]*z for _ in range(y)]for _ in range(x)]

    for i in range(1, x):
        for j in range(1, y):
            for k in range(1, z):
                if i<j and j < k:
                    arr[i][j][k] = arr[i][j][k-1] + arr[i][j-1][k-1] - arr[i][j-1][k]

                else:
                    arr[i][j][k] = arr[i-1][j][k] + arr[i-1][j-1][k] + arr[i-1][j][k-1] - arr[i-1][j-1][k-1]
    return arr[x-1][y-1][z-1]


while True:
    a, b, c = map(int, input().split())
    if a == -1 and b == -1 and c == -1:
        break
    elif a <= 0 or b <= 0 or c <= 0:
        t = 1
        print('w(%d, %d, %d) = %d' % (a, b, c, t))
    elif a > 20 or b > 20 or c > 20:
        t = dp(21, 21, 21)
        print('w(%d, %d, %d) = %d' % (a, b, c, t))
    else:
        t = dp(a+1, b+1, c+1)
        print('w(%d, %d, %d) = %d' % (a, b, c, t))
