level = int(input())

rst = [0 for i in range(15)]
cnt = 0


def chess(depth):
    global cnt
    if depth > level:
        cnt += 1
    else:
        for i in range(1, level + 1):
            rst[depth] = i
            if promising(depth):
                chess(depth + 1)


def promising(depth):
    for i in range(1, depth):
        if rst[depth] == rst[i] or depth - i == abs(rst[depth] - rst[i]):
            return False
    return True


chess(1)
print(cnt)

