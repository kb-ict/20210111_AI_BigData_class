library(KoNLP)
library(wordcloud2)
library(httr)
library(XML)

useNIADic()

url <- "http://news.daum.net"
web <- GET(url)
tail(web)

html <- htmlTreeParse(web,useInternalNodes = T,trim = T,encoding = "utf-8")

rootNode <- xmlRoot(html)
rootNode

news <- xpathApply(rootNode, "//a[@class='link_txt']", xmlValue)
news

newsPre <- gsub("[\r\n\r]", " ", news)
# 구두점 제거
newsPre <- gsub("[[:punct:]]", " ", news)
# cotrol 문자
newsPre <- gsub("[[:cntrl:]]", " ", news)

newsPre <- gsub("[a-z]", " ", news)

newsPre <- gsub("[A-Z]", " ", news)

newsPre

newsData <- newsPre[1:46]
newsData

write.csv(newsData,"D:/20210111_AI_BigData_class/홍성인/R_Project_2021/res/daum0527_news.csv",quote=F)

#===============================================================================
newsData2 <- read.csv("D:/20210111_AI_BigData_class/홍성인/R_Project_2021/res/daum0527_news.csv",
                      header = T, stringsAsFactors = F)
#newsData2 <- names(newsData2, c("num","content"))
names(newsData2) <- c("no","title")
str(newsData2)
newsTitle <- newsData2$title
#===============================================================================

exNouns <- function(x) {
  paste(extractNoun(x), collapse = " ")
}

newsNouns <- sapply(newsTitle, exNouns)
str(newsNouns)

newsCorpus <- Corpus(VectorSource(newsNouns))
inspect(newsCorpus[1:5])
tdm <- TermDocumentMatrix(newsCorpus,control = list(wordLengths=c(4,16)))
tdm

# 직계 행렬 구조 matrix -> dataframe
tdmDF <- as.data.frame(as.matrix(tdm))
wordResult <- sort(rowSums(tdmDF),decreasing = T)
head(wordResult)

myNames <- names(wordResult)
wordDF <- data.frame(word=myNames,freq=wordResult)

wordcloud2(wordDF,fontFamily = "맑은 고딕",size=1.0,color="random-light",
           backgroundColor="black",shape="star")
