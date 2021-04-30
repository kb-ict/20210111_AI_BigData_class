library(readxl)
library(xlsx)

excelData <- read_excel('res/data_ex.xlsx')
View(excelData)

studentx <- read.xlsx(file.choose(),sheetIndex = 1,encoding = 'UTF-8')
studentx

View(studentx)

#==============================[ 연습문제 ]=====================================

# 1. "2021-04-29 수입3000원",
#    "2021-04-30 수입4500원",
#    "2021-05-01 수입5500원",
# 위의 문자열을 이용하여 아래와 같이 출력하세요
# 출력형태 -> "3000원""4500원""5500원"

# 2. 1번에서 '-'를 '/'로 변경하세요 ( str_replace_all() 사용 )

# 3. 임의의 국어, 영어 수학 점수를 가지는 벡터3개 생성
# ex) kor <- c(90,85,100)

# 4. 3번 벡터를 가지는 data frame 생성

# 5. 국,영,수 data frame에서 최대값 구하기
# -> apply(object,1,max) : 가로방향
# -> apply(object,2,max) : 세로향향

#===============================================================================

# 1번
exam <-c('2021-04-29','2021-04-30','2021-05-01',
               '수입3000원','수입4500원','수입5500원')
exam
str_extract_all(exam,'[0-9]{4}[가-힣]{1}')

# 2번
str_replace_all(exam,'-','/')

# 3번
exam3 <-list(kor=c(100,95,90),
             eng=c(90,85,80),
             math=c(95,90,85))
exam3

# 샘 코드
kor <- c(100,90,80)
eng <- c(95,85,90)
math <- c(85,80,100)

# 4번
exam4 <-data.frame(kor,eng,math)
exam4

# 5번
exam5 <-apply(exam4,1,max)
exam5
exam6 <-apply(exam4,2,max)
exam6

#==============================[ Review ]=======================================
# 1번
answer1 = c('2021-04-29','2021-04-30','2021-05-01',
            '수입3000원','수입4500원','수입5500원')
str_extract_all(answer1,'[0-9]{4}[가-힣]{1}')

# 2번
answer2 <- str_replace_all(answer1,'-','/')
answer2

# 3번
answer3 <- list(kor = c(100,90,80),
                eng = c(95,85,100),
                math = c(90,80,95))
answer3

# 4번
answer4 <- data.frame(answer3)
answer4

# 5번
answer5_1 <- apply(answer4,1,max)
answer5_1
answer5_2 <- apply(answer4,2,max)
answer5_2
#===============================================================================

txtData <- read.table('res/data_ex.txt')
View(txtData)

# header : 데이터에서 1행이 변수명인지 판별
# ex) 1행이 변수명이면 header = TRUE

# skip : 특정 행까지 제외하고 데이터 가져오기
# ex) 3행부터 가져오기 -> skip = 2

# nrows : 특정 행까지 데이터 가져오기
# ex) 7행까지 데이터 가져오기 -> nrows = 7

# sep : 데이터 구분자 지정
# ex) 쉼표로 구분된 데이터 집합 -> ','

textData1 <- read.table('res/data_ex1.txt',
                        header = TRUE,
                        sep = ',')
View(textData1)
varName <- c('ID','성별','나이','지역','기타')
txtVar <- read.table('res/data_ex2.txt',
                     sep = ',',
                     col.names = varName)
View(txtVar)

# .rda(통계용 파일)
id <- c(1,2,3,4,5)
name <- c('홍길동','김길동','이길동','박길동','최길동')
rdaData <- data.frame(ID=id, NAME=name)

# rda file 저장
save(rdaData, file='res/data_ex.rda')
load('res/data_ex.rda')
View(rdaData)

#===============================================================================

id <- c(1,2,3,4,5)
name <- c('홍길동','김길동','이길동','박길동','최길동')

dataCsv <- data.frame(ID=id,NAME=name)
write.csv(dataCsv, file = 'res/data_ex.csv')

dataTxt <- data.frame(ID=id, NAME=name)
write.table(dataTxt,file = 'res/data_ex_sav.txt')

titanic <- read.csv('https://vincentarelbundock.github.io/Rdatasets/csv/COUNT/titanic.csv')
titanic

# data 차수 확인
dim(titanic)
# data 구조 확인
str(titanic)

# data 빈도 확인
table(titanic$age)
table(titanic$sex)
table(titanic$survived)

head(titanic)
tail(titanic)

# 교차 분할표
tab <- table(titanic$survived, titanic$sex)
tab

plot(tab, col=c('green','blue'),
     main = '성별에 따른 생존 여부')

barplot(tab, col = c('green','blue'),
        main = '성별에 따른 생존 여부')

write.table(titanic, 'res/titanic.txt',
            row.names = FALSE)

titanicDf <- read.table(file = 'res/titanic.txt',
                        sep='',header = T)
View(titanicDf)
write.csv(titanicDf, 'res/titanic.csv',
          row.names = F, quote = T)

library(writexl)
write_xlsx(x=titanicDf, path = 'res/titanic.xlsx',
           col_names = T)


