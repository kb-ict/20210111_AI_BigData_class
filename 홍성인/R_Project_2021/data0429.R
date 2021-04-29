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
