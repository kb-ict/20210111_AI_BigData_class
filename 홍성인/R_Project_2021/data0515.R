library(devtools)
#install_github('dkahle/ggmap')
library(ggmap)

apikey = 'AIzaSyD0wdEwMrXflnQU0pZhnRK_P6M2qDt7wUg'

register_google(apikey)
ggDaegu <- get_googlemap('daegu', maptype = 'hybrid')
ggmap(ggDaegu)
