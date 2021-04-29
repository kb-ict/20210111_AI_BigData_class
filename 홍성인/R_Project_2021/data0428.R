
ex_vector <- c(1,2,3,4,5,6)
ex_vector
print(ex_vector)
ex_vector[c(1,5)]
ex_vector[1:3]

ex_vector <- c('홍길동','김길동','박길동')
ex_vector[c(1,3)]
ex_vector[1:2]

ex_vector <- c(1:6)     # 1 ~ 6까지 배열 생성
matrix(ex_vector, nrow = 2, ncol = 3) # 1차원 백터를 2차원 매트릭스로 (2행3열)
matrix(ex_vector, nrow = 3, ncol = 2) # 열부터 정리해라
matrix(ex_vector, nrow = 3, ncol = 2, byrow = T) # 행부터 정리해라

#============================[3차원 배열]======================================
# 3차원 배열 = 2차원 배열이 n개 있음

arr <- c(1:12)
array(arr, dim = c(2,2,3))  # 2 * 2 배열이 3개 있음
array(arr, dim = c(2,2,3),
      dimnames = list(c('1행', '2행'),
                      c('1열', '2열'),
                      c('1페이지', '2페이지','3페이지')))

#============================[연습 문제]========================================
# 1. 'R'문자가 5회 반복 처리되는 벡터 : rep() 함수 사용
# 2. 1~10까지 3간격으로 연속되는 벡터 : seq() 함수
# 3. 1~10까지 3간격으로 연속된 정수가 3회 반복 : rep() 함수
# 4. 2,3번이 모두 포함되는 벡터
# 5. 4번에서 홀수번째 값들만 저장하는 벡터
#===============================================================================
# 1번
vec1 <- rep('R',5)
vec1

# 2번
vec2 <- seq(1,10,by=3)
vec2
#for (i in vec2) {
#  print(i)
#}

# 3번
vec2 <- seq(1,10,by=3)
vec3 <- rep(vec2,3)
vec3

# 4번
vec4 <-c(vec2, vec3)
vec4

# 5번
vec5 <- vec4[seq(1,16,by=2)]
vec5

#=================================[ 리스트 ]====================================

list1 <- list(c(1,2,3),c('홍길동','이길동'),TRUE,12.5)
list1

list2 <- list(c('홍길동','김길동','박길동'),c(20,30,40))
names(list2) <- c('NAME','AGE')
print(list2[1])
print(list2$NAME[1])
print(list2$AGE[2])

#===============================================================================

member <- list(name=c('홍길동','전우치'),
               age=c(200,300),
               address=c('서울','대구'),
               gender=c('남자','여자'),
               home=c('동구','북구'))
member
member$name
member$name[1]
member$name[2]

member$age[1] <- 100
member$age

member$address[1] <- '부산'
member$address

member$home[2] <- '전원주택'
member$home

#===============================[ data frame 1 ]================================

id <- c(1,2,3,4,5)
gender <- c('M','F','M','F','F')
age <- c(25,32,45,51,12)
addr <- c('서울','대전','광주','대구','부산')
dataValue <- data.frame(id,gender,age,addr)
dataValue
mode(dataValue)
class(dataValue)
View(dataValue)

#===============================================================================

dataVal <- edit(data.frame())
dataVal

#===============================[ data frame 2 ]================================

id_r1 <- c('a1','a2','a3','a4')
name_r1 <- c('김길동','이길동','홍길동','박길동')
stu_r1 <- data.frame(id_r1,name_r1)
stu_r1

stu_r2 <- data.frame(
  id_r2 = c('j1','j2','j3','j4'),
  name_r2 = c('전우치','김우치','이우치','박우치'))
stu_r2

names(stu_r1) <- c('ID','이름')
names(stu_r2) <- names(stu_r1)


#행 결합
studRbind <-rbind(stu_r1,stu_r2)
studRbind

#===============================================================================

stu_c1 <- data.frame(
  id = c('i1','i2','i3'),
  name = c('홍','김','박'))
names(stu_c1) <- c('ID','이름')
stu_c1

stu_c2 <- data.frame(
  age = c(20,30,40),
  gender = c('M','F','M'))
names(stu_c2) <- c('나이','성별')
stu_c2

# 열 결합
stuCbind <- cbind(stu_c1,stu_c2)
stuCbind

#===============================================================================

stu_j1 <- data.frame(
  id = c('i1','i2','i3'),
  name = c('홍','김','박'))
names(stu_j1) <- c('ID','이름')
stu_j1

stu_j2 <- data.frame(
  id = c('i2','i3','i4'),
  gender = c('M','F','M'))
names(stu_j2) <- c('ID','성별')
stu_j2

# id가 일치하는 data 합친다
studJoin <- merge(x = stu_j1, y = stu_j2, by = 'ID')
studJoin

#===============================================================================

# 라이브러리 설치 안될 때
# 1. 관리자 권한으로 cmd 실행
# 2. C:\Program Files\R\R-4.0.5\bin 에서 R.exe 실행
# 3. install.packages('stringr) 설치

#===============================================================================

install.packages('stringr')
library(stringr)

# 1~9사이의 연속되는 숫자2개를 추출한다
strData <- c('홍길동35이순신45유관순25')
str_extract(strData,'[1-9]{2}')
str_extract_all(strData,'[1-9]{2}')

strData1 <- 'rooney0247radung1004강감찬2005'
str_extract_all(strData1,'[a-z]{3}')
str_extract_all(strData1,'[a-z]{3,}')
str_extract_all(strData1,'[a-z]{3,6}')

str_extract_all(strData1, 'radung')
str_extract_all(strData1,'1004')
str_extract_all(strData1, '[가-힣]{3}')
str_extract_all(strData1, '[a-z]{3}')
str_extract_all(strData1, '[0-9]{4}')

# 알파벳을 제외한 정보들을 추출한다
str_extract_all(strData1, '[^a-z]')
str_extract_all(strData1, '[^a-z]{4}')
str_extract_all(strData1, '[^가-힣]{10}')
str_extract_all(strData1, '[^0-9]{3}')

# 7자의 정보들을 추출한다( w = word , d = decimal )
name <- '홍길동1234,이순신5678,김길동1011'
str_extract_all(name, '\\w{7,}')
str_extract_all(name, '\\d')
str_match_all(name, '\\d')

size <- str_length(name)
size

# 특정 data가 들어있는 index값을 나타낸다
str_locate(strData1, '강감찬')

# 문자열을 1부터 끝까지 문자열 10개를 뺀 값을 추출한다
strDataSub <- str_sub(strData1, 1, str_length(strData1)-10)
strDataSub

# 세미콜론은 'add'의 역할을 한다
# 소문자(lower)를 대문자(upper)로 변환한다
upstr <- str_to_upper(strDataSub); upstr
str_to_lower(upstr)

# 주민등록번호 생성하기 
jumin <- '123456-5234567'
str_extract(jumin,'[0-9]{6}-[1-4][0-9]{6}')

# 1974년 미국 자동차 잡지 data frame
mtcars

# str()함수는 data frame의 구조를 확인 할 수 있다
str(mtcars)
head(mtcars)
tail(mtcars)

# 32 * 11 
dim(mtcars)

length(mtcars)
length(mtcars$cyl)

# 각각의 속성 정보들을 표시한다
names(mtcars)

class(mtcars)
mode(mtcars)
# 각각의 속성의 타입을 표시한다
sapply(mtcars, class)
