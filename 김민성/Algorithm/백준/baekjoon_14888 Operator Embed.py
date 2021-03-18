import sys


def solution(num, idx, sumt, sub, multi, div):
    global max_num, min_num, n
    if idx == n:
        max_num = max(max_num, num)
        min_num = min(min_num, num)
        return
    else:
        if sumt:
            solution(num + nums[idx], idx + 1, sumt - 1, sub, multi, div)

        if sub:
            solution(num - nums[idx], idx + 1, sumt, sub - 1, multi, div)

        if multi:
            solution(num * nums[idx], idx + 1, sumt, sub, multi - 1, div)
        if div:
            solution(int(num / nums[idx]), idx + 1, sumt, sub, multi, div - 1)


max_num = -sys.maxsize
min_num = sys.maxsize

n = int(input())
nums = list(map(int, input().split()))
lis = list(map(int, input().split()))

solution(nums[0], 1, lis[0], lis[1], lis[2], lis[3])

print(max_num)
print(min_num)
