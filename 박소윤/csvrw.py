import csv

def doRead():
    file = open("a.csv","r")    #파일 열기
    rd = csv.reader(file)       #읽는 버퍼 가져오기
    for line in rd:             #한줄씩 꺼내면서 line에 넣기
        print(line)             # line 출력
    file.close()                #파일 닫기

def doWrite():
    file = open("a.csv","w",newline='')
    wr = csv.writer(file)
    wr.writerow(['1','test0','aaa'])
    wr.writerow(['2', 'test1', 'bb'])
    wr.writerow(['3', 'test2', 'cc'])
    file.close()