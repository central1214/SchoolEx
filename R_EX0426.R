#09번 문제
d <- c(100:200)
print(d)
print(d[10])
print(d[91:100])
print(d[seq(2,100,2)])
print(d[seq(3,100,3)])
d.20 <- d[1:20]
print(d.20)
print(d.20[-5])
print(d.20[-c(5,7,9)])
#10번 문제
absent <- c(10,8,14,15,9,10,15,12,9,7,8,7)
names(absent) <- c('JAN','FEB','MAR','APR','MAY','JUN','JUL','AUG','SEP','OCT','NOV','DEC')
print(absent)
print(absent['MAY'])
print(absent['JUL']+absent['SEP'])
total = 0
x <- c(1:6)
for (i in x){
  total <-  total + absent[i]
}
print(total)#상반기 결석생 수
t <- c(7:12)
total <- 0
for (i in t){
  total <-  total + absent[i]
}
print(total)#하반기 결석생 수

#11번 문제
f1 <- 1:50
f2 <- 51:100
print(f1)
print(f2)
length(f2)
print(as.numeric(f1)+as.numeric(f2))
print(as.numeric(f1)-as.numeric(f2))
print(as.numeric(f1)*as.numeric(f2))
print(as.numeric(f1)/as.numeric(f2))
print(max(f2))
print(min(f2))
mean(f1)
mean(f2)
print(mean(f2)-mean(f1))
sort(f1, decreasing = T)
f3 <- c(f1[1:10],f2[1:10])
print(f3)
