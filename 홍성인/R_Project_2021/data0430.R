# 1.동전 앞면과 뒷면에 대한 확률 함수 구현하기
# 랜덤 생성 : runif() , 1(앞면), 0(뒷면)

# 2. 동전 20회 던졌을 때 앞,뒤를 출력하기

# 3. 몬테칼를로 시뮬레이션, 2번의 함수를 사용하여 시뮬레이션 함수 구현하기

runif(5,min = 0,max = 1)

# 문제 1번
coin <- function(){
  x <- runif(1)
  if (x<0.5){
    face <- '앞면'
  } else {
    face <- '뒷면'
  }
  return(face)
}
coin()

# 문제 2번
coin2<-function(){
  for ( i in 1:20) {
    x <- runif(1)
    if (x<0.5){
      face <- '앞면'
    } else {
      face <- '뒷면'
    }
    print(face)
    }
}
coin2()
# 문제 3번
pi <- function(n) {
  counter <- 0;
  for (i in 1:n) {
    coordinates <- runif(2,-1,1)
    if (sqrt(coordinates[1]^2 + coordinates[2]^2) < 1) {
      counter <- counter + 1
    }
  }
  return(4*counter/n)
}

pi(10)

#===============================[Thu/6/May/2021]================================

runif(5,0,1)

coinTest <- function(n){
  r <- runif(n,0,1)
  res <- c()
  for (i in 1:n) {
    if (r[i] <= 0.5) {
      res[i] <- 0
    }
    else {
      res[i] <- 1
    }
  }
  return(res)
}

res <- coinTest(5)
res
hist(res)

#===============================================================================

monteTest <- function(n) {
  cnt <- 0
  for (i in 1:n) {
    cnt <- cnt + coinTest(1)
  }
  result <- cnt / n
  return(result)
}

monteTest(2)
monteTest(10000)
monteTest(1000000)
