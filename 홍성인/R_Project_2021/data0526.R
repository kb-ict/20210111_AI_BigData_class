# 로지스틱 회귀분석
# 종족변수와 독립변수간의 관계를 구체적인 함수로 나타내어 향우 예측 모델에 사용
# 종속변수(범주형) - 독립변수(연속형) 
# 지도학습 분류되며, 특정 결과의 분류 및 예측 가능 
#===============================================================================
# mtcars dataset
# mpg : 연비(수치형)
# cyl : 실린더 갯수(수치형)
# disp : 배기량(수치형)
# hp : 마력(수치형)
# drat : 리어액슬(수치형) 비율 <- 후륜제어기술 
# vs : 엔진 종류(0:V-shaped,1=straight) <- 범주형
# am : 변속기 종류(0:automatic,1:mannual) <- 범주형
# gear : 전진 기어 갯수 (수치형)
# carb : 기화기 갯수 (수치형)
#===============================================================================
summary(mtcars)
# 로지스틱 회쉬분석의 종속변수는 이항 변수이므로 이항 분포 옵션 사용
#==========================[ family 옵션 분류 ]=================================
# 정규분포 : gaussian
# 이항분포 : binomial
# 포아송분포 : poisson
# 역정규분포 : inverse.gaussian
# 감마분포 : gamma
# 응답분포가 확실하지 않은 경우 : quasi
#===============================================================================
vsGlm <- glm(vs ~ mpg + am, data = mtcars, family = binomial)
summary(vsGlm)
vsGlm2 <- glm(vs ~ mpg + am + wt, data = mtcars, family = binomial)
summary(vsGlm2)
#===============================================================================
# 유의하지 않은 독립변수 제거 ( 후진 소거법)
stepVs <- step(vsGlm2, direction = "backward")
#==========================[ 통계검정방법 ]=====================================
# T-test : 비교그룹이 2개, 표본(샘플)이 독립적이고 데이터가 정규분포
# 위약을 먹은 집단과 치료제를 먹은 집단간의 혈압 차이
#===============================================================================
# 분산 분석(ANOVA) : 10대,20대,30대,40대.50대 간의 혈압 차이 
# 3개 이상의 다수 집단을 비교할때 사용
#===============================================================================
# 연속형 자료 검정 : T-test(이항), anova(다항)
# --> 수치화 가능 : 키, 몸무게
# 범주형 자료 검정 : 카이제곱검정, 피셔의 정확검정법
# --> 수치 불가능 : 성별, 혈액형
#===============================================================================
anova(vsGlm2, test = "Chisq")
#===============================================================================
#사전 확률:특정사건이 일어나기 전의 확률
#사후 확률:특정사건이 이미 발생하였는데 이 사건의 근본원인이 무엇인지 불확실한 상황
#기준설정을 0.5로 설정
#사후 확률이 0.5초과이면 stright 엔진으로 예측
#사후 확률이 0.5이하이면 V-shaped 엔진으로 예측
#===============================================================================
rawData <- mtcars
predict_prob <- predict(stepVs, newdata = rawData, type = "response")
# vs 예측값
predictVs <- ifelse(predict_prob > 0.5, 1, 0)
result <- data.frame(actual=rawData$vs, predicted=predictVs, pred_prob=predict_prob)
head(result)
#===============================================================================
# 혼돈 행렬 (confusion matrix) 
# -> 특정 분류 모델의 성능을 평가하는 지표
# -> 실제값과 모델이 에측한 에측값을 한눈에 알아볼수 있게 배열한 행렬
#===============================================================================
library(caret)
confusionMatrix(as.factor(rawData$vs),as.factor(result$predicted))
