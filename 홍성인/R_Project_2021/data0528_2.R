library(readxl)
library(caret)

creditData <- read.csv("D:/20210111_AI_BigData_class/홍성인/R_Project_2021/res/credit.csv",stringsAsFactors = T)
View(creditData)

# 대출기간
summary(creditData$months_loan_duration)
# 대출금액
summary(creditData$amount)
# default : no(미상환) , yes(상환)
table(creditData$default)

set.seed(12345)
#===============================================================================

# order : 오름차순으로 정렬, 자동으로 결측치 제거하는 함수
creditRandData <- creditData[order(runif(1000)), ]
summary(creditData$amount)
summary(creditRandData$amount)
head(creditData$amount)
head(creditRandData$amount)

# 학습용:900, 테스트용:100
creditTrain <- creditRandData[1:900, ]
creditTest <- creditRandData[901:1000, ]

prop.table(table(creditTrain$default))
prop.table(table(creditTest$default))

#===============================================================================
library(C50)
creditModel <- C5.0(creditTrain[-17],creditTrain$default)
summary(creditModel)

creditPred <- predict(creditModel,creditTest)
table(creditPred)

library(gmodels)

# 교차분석은 두개 이상의 범주형 변수를 대상으로 교차 분할표를 작성, 변수 상호 간의
# 관련성 여부를 분석한다

CrossTable(creditTest$default,creditPred,dnn=c("Actual","Predict"))

#===========================[ chi-square 검정 ]=================================

# -> 교정분석으로 얻어진 교차 분할표를 대상으로 유의 확률(p값)을 적용하여 변수들 
#    간의 독립성 및 관련성 여부등을 검정하는 분석

#================================[ 앙상블 기법 ]================================

# -> 단독 모델로 예측하는 것이 아닌 여러 모델을 생성하여 예측을 하고 평균을 통해
#    이 결과를 예측한다

# 1. Boosting : 가중치를 이용하여 약한 학습기를 강한 학습기로 만드는 방법

# 2. Bagging : 부트스트랩을 집계하는 것 (부트스트랩 : random sampling을 적용하는 방법)
# -> 학습 데이터가 충분하지 않더라도 부트스트랩을 집계하여 충분한 학습효과를 주는 효과
# -> 랜덤 포레스트 분석

#===============================================================================
creditBoost10 <- C5.0(creditTrain[-17],creditTrain$default,trials = 10)
summary(creditBoost10)
creditBoost10Pred <- predict(creditBoost10,creditTest)
CrossTable(creditTest$default,creditBoost10Pred,dnn=c("Actual","Predict"))
#===============================================================================
creditBoost100 <- C5.0(creditTrain[-17],creditTrain$default,trials = 100)
summary(creditBoost100)
creditBoost100Pred <- predict(creditBoost100,creditTest)
CrossTable(creditTest$default,creditBoost100Pred,dnn=c("Actual","Predict"))
