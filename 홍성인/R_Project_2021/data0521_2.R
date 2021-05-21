library(jsonlite)
library(ggplot2)

api<-"http://apis.data.go.kr/B552584/ArpltnInforInqireSvc/getMinuDustFrcstDspth"
apiKey<-"KWPZMQg1neeQbq%2FmXFg7cEJWmE1vJAetZe0yXR40jat78hltTB7GfkvMCtuF%2FdpShFwM0sr312mMZ4avNxdLKA%3D%3D"
returnType <- "json"
numOfRows <- 100
pageNo <- 1
InformCode <- "PM10"

url <- paste(api, "?serviceKey=", apiKey, "&returnType=", returnType,
             "&numOfRows=", numOfRows, "&pageNo=", pageNo, "&InformCode=", InformCode,
             sep = "")
url
#===============================================================================
jsonData <- fromJSON(url)
str(jsonData)
#===============================================================================
df <- data.frame(jsonData$response$body$items$informCode,
                 jsonData$response$body$items$dataTime)
df
#===============================================================================
ggplot(data = df, aes(x = dataTime, y = informCode)) + geom_bar(stat = "identity",
                                                                fill = "navy")
#===============================================================================
ggplot(data = df, aes(x = dataTime, y = informCode, fill = informCode)) + 
  geom_bar(stat = "identity") + theme(axis.text.x = element_text(angle = 90)) + 
  labs(title = "대기질 예보통보 조회", x = "통보날짜" , y = "통보코드") +
  scale_fill_manual(values = rainbow(10))
#===============================================================================
ggplot(data = df, aes(x = dataTime, y = informCode, fill = informCode)) + 
  geom_bar(stat = "identity") + theme(axis.text.x = element_text(angle = 90)) + 
  labs(title = "대기질 예보통보 조회", x = "통보날짜" , y = "통보코드") +
  scale_fill_manual(values = rainbow(7)) + coord_flip()
#===============================================================================
