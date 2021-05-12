library(readxl)
exdata1 <- read_excel('res/sample1.xlsx')
exdata1

# 빈도수 분석
install.packages('descr')
library(descr)

freq(exdata1$AREA, plot = T)

# stem and leaf plot
# 통계적 자료를 줄기, 잎, 도수로 표현
# 0 | 86 <- 분포범위 | 도수 
stem(exdata1$AGE)
exdata1$AGE

# histogram = 구간별 빈도수
hist(exdata1$AGE)
hist(exdata1$AGE, xlim = c(0,100), ylim = c(0,10), main = '나이 분포포')
hist(exdata1$AGE, main = '계좌이용 나이분포', xlab='나이 구간', ylab='나이 분포',
     xlim=c(1,100), col='green',probability=T)
hist(exdata1$AGE, main = '계좌이용 나이분포', xlab='나이 구간', ylab='나이 분포',
     col='green', freq=T, breaks=5)

# whisker : 상자의 좌우, 상하로 뻗어나간 선
#박스내의 가로선 : 중앙값
# lower whisker : 최소값
# -> 중앙값 - 1.5 * IQR 보다 큰 데이터 중 가장 작은 값
# upper whisker : 최소값
# -> 중앙값 - 1.5 * IQR 보다 작은 데이터 중 가장 큰 값
# IQR ( Inter Quntile Range)
# -> Q3(3사분위수) - Q1(1사분위수) = IQR

boxplot(exdata1$Y17_CNT, exdata1$Y16_CNT)
quantile(exdata1$Y17_CNT)
quantile(exdata1$Y16_CNT)

boxplot(exdata1$Y17_CNT, exdata1$Y16_CNT,
        ylim=c(0,60), main='BoxPlot',
        names = c('17년 계좌건수', '16년 계좌건수'),
        col=c('green','yellow'))

char_data <- c(305,450,320,460,330,480,380,520)
names(char_data) <- c('2018 1분기','2019 1분기',
                      '2018 2분기','2019 2분기',
                      '2018 3분기','2019 3분기',
                      '2018 4분기','2019 4분기')

#===============================================================================

barplot(char_data, ylim = c(0,600),
        ylab='매출액(단위:백만원)',
        xlab='년도별 분기 현황',
        col = rainbow(7), main = '2018년 vs 2019년 매출현황 비교')

barplot(char_data, xlim = c(0,600), horiz = T,
        ylab='매출액(단위:백만원)',
        xlab='년도별 분기 현황',
        col = rainbow(7), 
        main = '2018년 vs 2019년 매출현황 비교')

barplot(char_data, xlim = c(0,600), horiz = T,
        ylab='매출액(단위:백만원)',
        xlab='년도별 분기 현황',
        col = rainbow(7),
        space=0.5, cex.names=0.8,
        main = '2018년 vs 2019년 매출현황 비교')

#===============================================================================

VADeaths

par(mfrow=c(1,1))
barplot(VADeaths, beside = T, col = rainbow(5),
        main = '버지니아 하위계층 사망비율')

legend(19, 71, c('50-54','55-59','60-64',
                 '65-69','70-74'),
       cex=0.8, fill = rainbow(5))

barplot(VADeaths, beside = F, col = rainbow(5))
title(main = '버지니아 하위계층 사망비율',font.main=4)
legend(4, 200, c('50-54','55-59','60-64',
                 '65-69','70-74'),
       cex=0.8, fill = rainbow(5))

#===============================================================================
# pch = 도표를 나타내는 모양
par(mfrow=c(1,1))
dotchart(char_data, color = c('blue','red'),
         lcolor = 'black',pch = 1:2,
         labels = names(char_data),
         xlab = '매출액',
         main='분기별 판매현황 : Dot Chart',
         cex=1.2)

par(mfrow=c(1,1))
pie(char_data, labels = names(char_data),
    col = rainbow(5), cex=1.2)
title('2018~2019년도 분기별 매출현황')

#===============================================================================

boxplot(VADeaths,range=0)
boxplot(VADeaths,range=0, notch=T)

#===============================================================================

data(iris)
str(iris)
summary(iris$Sepal.Length)
hist(iris$Sepal.Length, xlab = '꽃받침 길이',
     col='green',
     main='iris 꽃받침 길이 Histogram',
     xlim=c(4.3,7.9))

summary(iris$Sepal.Width)
hist(iris$Sepal.Width, xlab = '꽃받침 너비',
     col='yellow',
     main='iris 꽃받침 너비 Histogram',
     xlim=c(2.0,4.5))

#===============================================================================

# c(1,2) = 1행2열
par(mfrow=c(1,2))
#par(mfrow=c(2,2))
hist(iris$Sepal.Width, xlab = '꽃받침 너비',
     col='yellow',
     main='iris 꽃받침 너비 빈도수',
     xlim=c(2.0,4.5))

hist(iris$Sepal.Width, xlab = '꽃받침 너비',
     col='green', freq=F,
     main='iris 꽃받침 너비 확률 밀도',
     xlim=c(2.0,4.5))

# 밀도
lines(density(iris$Sepal.Width), col='red')
x <- seq(2.0,4.5,0.1)
x

# 히스토그램에 정규분포 곡선 추가가
curve(dnorm(x, mean=mean(iris$Sepal.Width),
      sd=sd(iris$Sepal.Width)),
      col='black',add = T)

# 산점도 : 좌표상에서 각각의 관찰값들을 점,특정문자로 표시하는 그래프
price <- runif(10,min = 1,max = 100)
price
plot(price,col='red')
par(new=T)
line_chart = 1:100
#===============================================================================
# p : points
# l : lines
# b : both(점+선)
# o : 점+선 중첩(overlap)
# s : 왼쪽값을 기초로 계단모양 연결
#===============================================================================
plot(line_chart, type='l', col='blue', axes=F, ann=F)
text(70,80, '대각선 추가',col='magenta')

par(mfrow=c(2,2))
plot(price, type = 'l')
plot(price, type = 'o')
plot(price, type = 'h')
plot(price, type = 's')
#===============================================================================
# lwd = 선굵기
par(mfrow=c(2,3))
plot(price, type = 'o', pch=5)
plot(price, type = 'o', pch=15)
plot(price, type = 'o', pch=20)
plot(price, type = 'o', pch='*',col='orange',cex=1.5)
plot(price, type = 'o', pch='*',col='green',cex=1.5, lwd=3)
#===============================================================================

#시계열 데이터 : 시간의 흐름에 따라 관찰된 데이터

data("WWWusage")
str(WWWusage)
plot(WWWusage)

kwData <- c(200,230,220,200,180,270,340,400,380,300,260,230)
plot(kwData)

tskwData <- ts(kwData, start = 1)
plot(tskwData)

#===============================================================================