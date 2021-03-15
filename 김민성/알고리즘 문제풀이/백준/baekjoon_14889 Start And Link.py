import sys
min_num = sys.maxsize
num = int(input())
arr = [list(map(int, input().split())) for i in range(num)]
import sys

input = sys.stdin.readline


def solution(x, cnt):
    global min_num, num

    if cnt == num // 2:
        star, link = 0, 0
        for j in range(len(values)):
            for k in range(len(values)):
                if rst[j] and rst[k]:
                    star += arr[values[j]][values[k]]
                elif not rst[j] and not rst[k]:
                    link += arr[values[j]][values[k]]

        min_num = min(abs(star - link), min_num)

    for i in range(x, num):

        if rst[i]:
            continue

        rst[i] = True

        solution(i + 1, cnt + 1)

        rst[i] = False


num = int(input())

arr = [list(map(int, input().split())) for i in range(num)]
min_num = sys.maxsize
rst = [0 for i in range(num)]
values = [i for i in range(num)]
solution(0, 0)
print(min_num)