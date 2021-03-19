n = int(input())


def fibo(n):
    rst = [(1, 0), (0, 1)]
    if n == 0:
        return rst[0]
    elif n == 1:
        return rst[1]

    for i in range(1, n):
        (x, y) = rst[i]
        (a, b) = rst[i - 1]
        rst.append((x + a, y + b))
    return rst[-1]

for i in range(n):
    x = int(input())
    (a, b) = fibo(x)
    print(a, b)



