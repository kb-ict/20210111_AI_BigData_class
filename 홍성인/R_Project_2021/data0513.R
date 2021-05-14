attributes(iris)
pairs(iris[iris$Species == 'virginica', 1:4])
pairs(iris[iris$Species == 'setosa', 1:4])
pairs(~Sepal.Width + Sepal.Length + Petal.Width + Petal.Length, 
      data = iris, col=iris$Species)
#===============================================================================
# 상관분석
# 두 변수가 서로 어떤 관계에 있는지 파악하는 분석 기법
#===============================================================================
# 공분산
# 각 확률변수들이 어떻게 퍼져있는지를 나타내는 것
# x의 표준편차와 y의 표준편차를 곱한것의 평균값
#===============================================================================
# 귀무 가설 : 두 변수는 서로 상관 관계가 없음. (r = 0)
# 대립 가설 : 두 변수는 서로 상관 관계가 있음. (r != 0)
#===============================================================================
# 상관계수 = 상관관계의 정도를 파악
#===============================================================================
# 상관계수 식
# x바 : 표본집단 x의 평균
# y바 : 표본집단 y의 평균
# Sx : 표본집단의 x의 표준편차
# Sy : 표본집단의 y의 표준편차
# n : 표본집단의 개수
#===============================================================================
# 피어슨(Pearson) 상관계수
# -> 상관분석에서 기본 사용
# -> -1 ~ +1 사이의 값을 가짐
# -> +-0.9 이상 : 매우 높은 상관 관계
# -> +-0.9 ~ +-0.7 : 높은 상관 관계
# -> +-0.7 ~ +-0.4 : 다소 높은 상관 관계
# -> +-0.4 ~ +-0.2 : 낮은 상관 관계
# -> +-0.2 미만 : 상관관계 없음
#===============================================================================
# 켄달(Kendal) 상관계수
# 스피어먼(Spearman) 상관계수
# -> 순위, 등급으로 변경해서 사용(학교등급, 졸업학위 성적)
#===============================================================================
# 공분산 = cov(x,y)
cov(mtcars$mpg, mtcars$cyl)
plot(mtcars$mpg, mtcars$cyl)
#===============================================================================
# 상관계수
cor(mtcars$mpg, mtcars$cyl)
plot(mtcars$mpg, mtcars$cyl)
#========================cor(mtcars$mpg, mtcars$cyl)============================
n <- length(mtcars$mpg)
mean_x <- mean(mtcars$mpg)
mean_y <- mean(mtcars$cyl)
s_x <- sd(mtcars$mpg)
s_y <- sd(mtcars$cyl)
z_x <- (mtcars$mpg - mean_x) / s_x
z_y <- (mtcars$cyl - mean_y) / s_y
sum(z_x * z_y) / (n-1)
#===============================================================================
# 결측치가 포함된 상관관계
cor(mtcars$mpg, mtcars$cyl,
    method = 'pearson',
    use = 'complete.obs')

cor(mtcars$mpg, mtcars$cyl,
    method = 'spearman',
    use = 'complete.obs')
#===============================================================================
# 3차원 산점도
library(scatterplot3d)
iris$Species
iris_setosa = iris[iris$Species == 'setosa', ]
iris_versicolor = iris[iris$Species == 'versicolor', ]
iris_virginica = iris[iris$Species == 'virginica', ]

d3 <- scatterplot3d(iris$Petal.Length,
                    iris$Sepal.Length,
                    iris$Sepal.Width, type = 'n')

d3$points3d(iris_setosa$Petal.Length,
            iris_setosa$Sepal.Length,
            iris_setosa$Sepal.Width,
            bg = 'red', pch=21)

d3$points3d(iris_versicolor$Petal.Length,
            iris_versicolor$Sepal.Length,
            iris_versicolor$Sepal.Width,
            bg = 'blue', pch=23)

d3$points3d(iris_virginica$Petal.Length,
            iris_virginica$Sepal.Length,
            iris_virginica$Sepal.Width,
            bg = 'green', pch=25)
#===============================================================================
str(trees)
scatterplot3d(trees, type = 'h', highlight.3d = 'T',
              angle = 55, scale.y = 0.8, pch = 3,
              main = '3차원 산점도 Trees')
#===============================================================================
exdata <- c(18,12,4,16,8,9,12)
lab <- c('미국','영국','호주','독일','캐나다','인도','한국')
library(plotrix)
pie3D(exdata, labels = lab, explode = 0.05, cex = 0.5,
      main = '3D Pie 차트')
legend('bottomright', legend = lab, cex = 0.9,
       fill = rainbow(length(exdata)))
#===============================================================================
# 화산자료 투시도
library(lattice)
wireframe(volcano, shade=T, aspect=c(61/87, 0.4),
          light.source = c(10,0,10))
wireframe(volcano, shade=T, aspect=c(61/87, 2),
          light.source = c(1,10,10))
#===============================================================================
library(ggplot2)
str(airquality)
ggplot(airquality, aes(x=Day, y=Temp))
airquality
#산점도
ggplot(airquality, aes(x=Day, y=Temp)) + geom_point()
ggplot(airquality, aes(x=Day, y=Temp)) + geom_point(size=3, color='red')
ggplot(airquality, aes(x=Day, y=Temp)) + geom_line()
ggplot(airquality, aes(x=Day, y=Temp)) + geom_line() + geom_point()
ggplot(airquality, aes(x=Day, y=Temp)) + geom_line(color='red',size=1) + geom_point(size=3)

ggplot(mtcars, aes(x=cyl)) + geom_bar(width = 0.5)
ggplot(mtcars, aes(x=factor(cyl))) + geom_bar(width = 0.5)
ggplot(mtcars, aes(x=factor(cyl))) + geom_bar(aes(fill=factor(gear)))
#===============================================================================
# 선버스트 차트
# 1.평면위의 위치를 각도로 거리를 사용하여 표시
# 2.두 점 사이의 관계를 각이나 거리로 표현
# 3.계층 구조 표현현

ggplot(mtcars,aes(x=factor(cyl)))+geom_bar(aes(fill=factor(gear)))+coord_polar()
ggplot(mtcars,aes(x=factor(cyl)))+geom_bar(aes(fill=factor(gear)))+coord_polar(theta = 'y')

# boxplot
ggplot(airquality,aes(x=Day,y=Temp,group=Day))+geom_boxplot()

# histogram
ggplot(airquality,aes(x=Temp))+geom_histogram(binwidth = 1)

library(googleVis)
motion <- gvisMotionChart(Fruits,idvar = 'Fruit',
                          timevar = 'Year')
plot(motion)

mydf <- data.frame(country=c('US','GB','BR'),
                   val1=c(10,13,14),
                   val2=c(23,12,32))
line <- gvisLineChart(mydf)
plot(line)

line2 <- gvisLineChart(mydf,'country',c('val1','val2'),options = list(
  series='[{targetAxisIndex:0},{targetAxisIndex:1}]', vAxes="[{title:'val1'},
  {title:'val2'}]"))
plot(line2)

bar <- gvisBarChart(mydf)
plot(bar)

#===============================================================================
# 뉴욕대기오염 dataset 사용
# 1. 특정달의 정보를 추출 (5~9)
# 2. x변수,y변수를 사용하여 상관분석 (산점도,상관계수,결측치 제거)
# 3. 변수 4개를 사용하여 상관분석 (산점도행렬) : R함수, ggplot2, google chart
#===============================================================================
airquality
str(airquality)
airquality$Month

dataset <- na.omit(airquality)
dataset

air_May = dataset[dataset$Month==5, ]
air_Jun = dataset[dataset$Month==6, ]
air_Jul = dataset[dataset$Month==7, ]
air_Aug = dataset[dataset$Month==8, ]
air_Sep = dataset[dataset$Month==9, ]

air_5<-air_May[,1:4]
air_6<-air_Jun[,1:4]
air_7<-air_Jul[,1:4]
air_8<-air_Aug[,1:4]
air_9<-air_Sep[,1:4]

cor(air_6)
plot(air_6)
#===============================================================================
ggplot(dataset,aes(x=Ozone,y=Temp))

ggplot(dataset,aes(x=Ozone,y=Temp)) + geom_point()
