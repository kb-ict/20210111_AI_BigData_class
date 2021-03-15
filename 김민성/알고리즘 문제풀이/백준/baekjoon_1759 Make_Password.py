# import sys
# input = sys.stdin.readline
# a, b = map(int, input().split())
# arr = list(map(str , input().split()))
# rst = [False] * b
# ost = []
#
#
# def dfs(depth):
#
#
#
#     if depth == a and pruning(ost):
#         print(*ost)
#
#         return
#
#
#
#
#
#     for i in range(0, b):
#         if rst[i]:
#             continue
#
#         rst[i] = True
#         ost.append(arr[i])
#         dfs(depth + 1)
#         ost.pop()
#         rst[i] = False
#
#
#
# def pruning(x):
#     aski = ['a', 'e', 'i', 'o', 'u']
#     cnt = 0
#     cou = 0
#     for i in range(len(x)):
#         if x[i] in aski:
#             cnt += 1
#         else:
#             cou += 1
#
#         if i > 0 and ord(x[i]) < ord(x[i - 1]):
#             return False
#
#     if cnt < 1 or cou < 2:
#         return False
#
#
#     else:
#         return True
#
# dfs(0) 최적화 전 코드


# 최적화 후 코드
import sys
input = sys.stdin.readline
a, b = map(int, input().split())
arr = list(map(str, input().split()))
arr.sort()
rst = [False] * b
ost = []


def dfs(depth, cnt):
    if len(ost) == a and pruning(ost):
        print(*ost, sep='')
        return


    for i in range(0, b):
        if cnt > ord(arr[i]):
            continue

        if rst[i]:
            continue

        cnt = ord(arr[i])
        rst[i] = True
        ost.append(arr[i])

        dfs(depth + 1, cnt)
        ost.pop()
        rst[i] = False



def pruning(x):
    moum = ['a', 'e', 'i', 'o', 'u']
    jaum = ['b', 'c','d','f','g','h','j','k','l','m','n','p','q','r','s','t','v','w','x','y','z']

    c = set(jaum)-set(x)
    if set(moum) - set(x) == set(moum):
        return False
    elif len(c) > 19:
        return False

    return True

num = -sys.maxsize
dfs(0, num)