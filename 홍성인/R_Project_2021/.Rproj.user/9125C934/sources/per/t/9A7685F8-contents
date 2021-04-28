# Ctrl + Enter : 한줄 또는 선택 영역 실행
# Ctrl + Alt + R : 전체 실행
# Ctrl + Alt + B : 처음에서 현재행까지 실행
# Ctrl + Alt + E : 현재행에서 마지막까지 실행
# 주석처리 : Ctrl + Shift + C
# ==============================================================================
n = 100
n <- 90
n <<- 80
n
print(n)
sprintf("점수: %d",n)
cat("점수: ",n)

# 개행문자(\) 쓸 때는 cat
x <- 10
y <- 20
z <- x * y
cat('x * y의 결과는',z,'입니다.\n')
sprintf('%d * %d = %d',x,y,z)

x <- 3.5
x
print(x)
sprintf('x:%.2f', x)

# 동적 바인딩 
y <- 'string'
print(y)
y <- "문자열"
y

z <- FALSE # (FALSE, F , TRUE , T)
z <- TRUE
z

#==============================[연산자]=========================================

10 + 3
10 - 5
2 * 3
10 / 2
10 %/% 3 # 정수값
5 %% 4 # 나머지
2 ^ 3 # 거듭제곱

#=============================[data 입력]=======================================

# 그냥 scan은 '숫자'를 입력받는다.
print('숫자를 입력하세요')
num <- scan()
num

# what은 '문자열'을 입력받는다.
print('문자열을 입력하세요')
str <- scan(what='')
str

# data frame 생성 후 data를 edit한다.
df <- data.frame() # data frame
df <- edit(df)
df

#==============================[조건문]=========================================

x <- 8
if (x > 0 && x < 10){
  print('1~10 사이의 숫자입니다.')
} else {
  print('1~10 사이의 숫자가 아닙니다.')
}

if ( x == 1 || x == 10){
  print('1이거나 10입니다.')
} else if ( x != 8){
  print('8이 아닙니다.')
} else {
  sprintf('정보는 %d 입니다.',x)
}

#===============================================================================

num <- 30
if (is.integer(num)){
  print('x는 숫자')
} else {
  print('x는 문자열')
}

# int 표현 시 -L을 추가한다
num <- 30
if (is.integer(num)){
  print('x는 int')
} else {
  print('x는 double')
}

#============================[ vector = 배열 ]==================================

data <- c('홍길동','김길동','박길동','이길동')
if ('박길동' %in% data){
  print('박길동이 존재합니다.')
} else {
  printf('박길동이 없습니다.')
}

i <- 0
while (i<10){
  i <- i + 1
  print(i)
}

#===============================================================================

sum <- 0
num <- c(1,4,7)
for (i in num ) {
  print(sum <- sum + i)
}

# next(=continue)는 for()로 다시 올라간다.
sum <- 0
for (i in 1:10){
  if (i %% 2 == 0){
    next
  }
  if (i == 7){
    break
  }
  sum <- sum + i
}
print(sum)

#===============================================================================

index <- seq(1,10,by=2)
for (i in index){
  print(i)
}

#===============================================================================

func1 <- function(start, end) {
  sum <- 0
  for (i in start:end) {
    sum <- sum + i
  }
  return(sum)
}

sprintf('합계: %d', func1(1,10))

#===============================================================================

func2 <- function(num1, num2, op){
  if (op == '+'){
    return (num1 + num2)
  } else {
    return (num1 - num2)
  }
}

func2_2 <- function(num1, num2){
  return(num1+num2)
}

func2_1 <- function(...){
  res <- func2(...)
  #val <- func2_2(...)
  return (res + val)
}
func2_1(10,5,'+')
func2_1(20,10,'-')

#===============================================================================

func_var <- function(...){
  var <- c(...)
  for (i in var) {
    cat(i,'\t')
  }
}
func_var(1,2)
func_var(1,2,3)
func_var(1,2,3,4,5)

#===============================================================================
# 질문하기
x <- 3
func1 <- function(){
  x <- 5
  print(x)
}
func1()
print(x)

func2 <- function(){
  x <<- 100
  print(x)
}

func2()
print(x)

#==================================[클로저]=====================================

add_x <- function(x) {
  function(y) {
    return(x + y)
  }
}

addx <- add_x(3)
addx(2)
