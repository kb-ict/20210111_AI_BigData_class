library(rvest)
url <-"http://www.ddaily.co.kr/news/article/?no=214976"
dat <- GET(url)
content(dat)
str(dat)

read_html(url)
