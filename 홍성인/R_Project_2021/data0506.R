library(readxl)
exdata1 <- read_excel('res/sample1.xlsx')
View(exdata1)
str(exdata1)
dim(exdata1)
ls(exdata1)

#===============================================================================

library('dplyr')
exdata1 <- rename(exdata1, Y17_AMT=AMT17,
                  Y16_AMT=AMT16)
View(exdata1)

exdata1$AMT_NEW <- exdata1$Y17_AMT + exdata1$Y16_AMT
exdata1$CNT_NEW <- exdata1$Y17_CNT + exdata1$Y16_CNT
View(exdata1)

#===============================================================================

exdata1$AVG_AMT <- exdata1$AMT_NEW / exdata1$CNT_NEW
View(exdata1)

#===============================================================================

exdata1$AVG_GR <-
  ifelse(exdata1$AGE >= 50, 'A1',
         ifelse(exdata1$AGE >= 40, 'A2',
                ifelse(exdata1$AGE >= 30, 'A3',
                       ifelse(exdata1$AGE >= 20, 'A4', 'A5'))))
View(exdata1)

#==========================[특정 속성값 추출1]==================================

exdata1 %>% select(ID)
exdata1 %>% select(ID, AREA, Y17_CNT)

#====================[특정 속성값 제외한 정보 추출]=============================

exdata1 %>% select(-AREA)
exdata1 %>% select(-ID, -GENDER, -AGE)

#==========================[특정 속성값 추출2]==================================

exdata1 %>% filter(AREA == '서울')
exdata1 %>% filter(AREA == '서울' & Y17_CNT >= 10)

#===============================================================================

exdata1 %>% arrange(AGE)
exdata1 %>% arrange(desc(AGE))

exdata1 %>% summarise(TOT_Y17_AMT=sum(Y17_AMT))
exdata1 %>% group_by(AREA) %>% summarise(SUM_AMT17_BY_AREA=sum(Y17_AMT))

#===============================================================================

mData <- read_excel('res/sample1_m.xlsx')
View(mData)

fData <- read_excel('res/sample1_f.xlsx')
View(fData)

exdata1_bindjoin <- bind_rows(mData, fData)
View(exdata1_bindjoin)

jeju_y17 <- read_excel('res/sample1_jeju_17.xlsx')
View(jeju_y17)
jeju_y16 <- read_excel('res/sample1_16.xlsx')
View(jeju_y16)

#===============================[내부 조인]=====================================

bind_col <- left_join(jeju_y17, jeju_y16, by='ID')  # 참조키 역활 : ID
View(bind_col)

bind_col2 <- right_join(jeju_y17, jeju_y16, by='ID')
View(bind_col2)

bind_col_inner <- inner_join(jeju_y17, jeju_y16, by='ID')
View(bind_col_inner)

bind_col_full <- full_join(jeju_y17, jeju_y16, by='ID')
View(bind_col_full)

#===============================================================================

x1 <- c(1,2,3,4,5,6,10)
avg <- x1/7
avg
# 평균
mean(x1)

#===============================[결측치 처리]===================================

data <- c(10,20,5,4,40,7,NA,6,3,NA,2,NA)

na <- function(x) {
  print(x)
  print(mean(x, na.rm=T))                               # NA를 remove한 평균값
  #print(median(x,na.rm=T))
  
  data = ifelse(!is.na(x), x, 0)                
  print(data)
  print(mean(data))
  
  data2 = ifelse(!is.na(x), x,
                 round(mean(x, na.rm = T), 2))
  print(data2)
  print(mean(data2))
}
na(data)

#============================[중앙값(중위수)]===================================
# 중앙값 = 가운데 2개의 값을 더해서 2로 나눈 값
x2 <- c(1,2,3,4,5,10)
median(x2)
max(x2)
min(x2)
range(x2)

#============================[분위수(변위값)]===================================
# 1사분위수(Q1), 2사분위수(Q2), 3사분위수(Q3)
quantile(x2)
quantile(x2, probs = 0.25)
quantile(x2, probs = 0.5)
quantile(x2, probs = 0.75)
quantile(x2, probs = 0.8)

#==============================[표준 편차]======================================
# 표준편차 = 평균값에 대한 오류(오차)
# 실제 데이터 값이 평균을 기준으로 할 때의 분포값
sd(x2)
# 분산 = 표준편차 제곱의 합
var(x2)

x <- c(1,2,3,4,5,10)
var_sd <- function(x) {
  # 데이터가 평균적으로 퍼져있는 정도
  n <- length(x)
  var <- sum((x-mean(x))^2)/(n-1)
  sd <- sqrt(var)
  cat('분산: ',var, '\n')
  cat('표준편차: ',sd)
}
var_sd(x)

#===============================================================================
# 정규분포 = 동일한 확률을 가진 변수들이 적당히 크면, 해당 변수들의 평균은 
#           일정한 패턴을 가지는 분포
library(fBasics)

# x변수 첨도 = 데이터 분포가 뾰족한 정도 
# 통계량이 0보다 크면 정규분포 대비 뾰족한 형태
# 0보다 작으면 정규분포 대비 평평한 형태
kurtosis(x)

# x변수의 왜도 = 데이터 분포의 비대칭성
# 통계량의 절대값이 클수록 비대칭이 심함
# +값이면 오른쪽으로 꼬리가 길고, 
# -값이면 왼쪽으로 꼬리가 긴 형태
skewness(x)

library(reshape2)
View(airquality)
head(airquality)

#===============================================================================

names(airquality) <- tolower(names(airquality))
melt_test <- melt(airquality)
melt_test
str(airquality)


melt_test2 <- melt(airquality,
                   id.vars = c('month','wind'),           # 기준열
                   measure.vars = 'ozone')                # 변환열
head(melt_test2)

#===============================================================================

melt_test3 <- melt(airquality,
                   id.vars = c("Month","Day"),
                   variable.name = "climate_variable",
                   value.name = "climate_value")
head(melt_test3)

#===============================================================================

# acast() : vector, matrix, array 변환
# dcast() : data frame 변환
aq_melt <- melt(airquality, id=c("month","day"),
                na.rm=T)
head(aq_melt)

aq_dcast <- dcast(aq_melt, month + day ~ variable)
class(aq_dcast)
head(aq_dcast)
head(airquality)
head(aq_melt)

#===============================================================================

acast(aq_melt, day ~ month ~ variable)
acast(aq_melt, month ~ variable ~ mean)
dcast(aq_melt, month ~ variable ~ mean)

#===============================================================================
# 1. ozone 합, 평균값, 표준편차, 분산 구하기 (NA값 제거)
# 2. 모든 NA값 제거 후, 각 월별로 측정값들의 평균
# 3. 5월달 평균 온도, 풍속
# 4. ozone 5월달의 합, 평균, 분산, 표준편차 
# -> NA값 제거,각각 R기본함수와 사용자 정의 함수 사용
# 5. 5월 7일 데이터 출력
# 6. 5/1 ~ 5/6까지 오존농도
# -> 기준열(month,day) 변환열(Ozone, Value)
# 7. 기온이 가장 높은 날짜를 기준으로 출력 (which max)
# 8. 기온이 가장 높은 날의 모든 데이터 출력
# 9. 6월달에 발생한 가장 강한 바람의 세기 출력
#===============================================================================
# 7번
airquality[which.max(airquality$temp),c('month','day')]
#===============================================================================
# 문제1)
sum(is.na(airquality$Ozone))
Ozone_1 <- na.omit(airquality$Ozone)
Ozone_1

sum(Ozone_1)             # 합
mean(Ozone_1)            # 평균
sd(Ozone_1)              # 표준편차
n <- sd(Ozone_1)    
var <- n^2  
var                      # 분산
#===============================================================================
# 5번
str(airquality)
airquality[airquality$Month==5 & airquality$Day==7,]
#===============================================================================
# 1번
names(airquality) <- tolower(names(airquality))
str(airquality)
class(airquality)

sum(airquality$ozone, na.rm = T)
mean(airquality$ozone, na.rm = T)
var(airquality$ozone, na.rm = T)
sd(airquality$ozone, na.rm = T)
#===============================================================================
# 9번
wind6 <- subset(airquality, month==6, select = wind)
class(wind6)
class(wind6$wind)
wind6[which.max(wind6$wind),]
#===============================================================================
library(dplyr)
fil_data <- filter(airquality, airquality$month==5)     # filter = 행 정보 추출
fil_data

sel_data <- select(fil_data, ozone)                     # select = 열 정보 추출
sel_data

mean(sel_data$ozone, na.rm = T)
