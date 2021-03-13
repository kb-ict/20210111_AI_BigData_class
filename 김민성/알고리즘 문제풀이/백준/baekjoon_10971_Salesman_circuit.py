import sys

input = sys.stdin.readline

n = int(input())
cities = [list(map(int, input().split())) for i in range(n)]
min_num = sys.maxsize



def dfs(cost, start, next_ ,visited):
    global min_num
    if len(visited) == n:
        if cities[next_][start] != 0:
            min_num = min(min_num, cost + cities[next_][start])
        return

    for i in range(n):
        if cities[next_][i] != 0 and i != start and i not in visited:
            # cost란 변수에 더해서 함수에 넣는것이 불가능해 보인다. ex) cost += cities[next_][i]
            visited.append(i)
            dfs(cost + cities[next_][i], start, i , visited)
            visited.pop()

for i in range(n):
    dfs(0, i, i, [i])


print(min_num)