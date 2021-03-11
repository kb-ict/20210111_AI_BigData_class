n = int(input())
rst = [i for i in range(1, n+1)]


def queen(dep):
    if dep > n:
        return

    else:
        for i in range(dep):
            rst[dep+1] = i
            if prun(dep+1):
                queen(dep+1)


def prun(depth):




