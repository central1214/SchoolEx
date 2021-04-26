as.Date("20/02/08","%y/%m/%d")
dates <- c('02/28/20','02/30/21','03/22/23')
as.Date(dates,'%m/%d/%y')
Sys.getlocale(category='LC_COLLATE')
Sys.time()
?max
max(10,20,30,NA,na.rm = T)
args(max)
example(max)
?seq
seq(0,1,0.01)
getwd()
setwd("C:/Users/KB/Documents/Github")
getwd()
data1 <- read.csv('students.csv',header = T)
data2 <- read.csv('coro.csv',header = T)
print(data)
class(data)
data1[1]
data1$math
data2$구분
data1[[4]]
data1[4]
math_avg <- (data1$math[1] + data1$math[2] + data1$math[3] + data1$math[4] + data1$math[5])/5
seojoon_avg <- (data[1,2]+data[1,3]+data[1,4])/3
options(digits = 4)
data$score <-c(seojoon_avg,seojoon_avg,seojoon_avg,seojoon_avg,seojoon_avg)

data
v1 = 50:1000
v1
v2 <- c(1,2,3,45,5,1000:1202)
v2
a = mean(100,90,100)
a
?mean
z = rep(2,3)
z

name <- c('Garen','Fizz','Ezreal')
names(name) <- c('top', 'mid', 'bottom')
print(position)

name <- c('Garen','Fizz','Ezreal','Samira','Twisted Fate')
name[c(1,3,5)]
name[1:3]
name[seq(1,5,2)]
name[-2]
name[-c(3:5)]
