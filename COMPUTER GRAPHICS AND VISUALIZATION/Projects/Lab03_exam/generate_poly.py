# Online Python compiler (interpreter) to run Python online.
# Write Python 3 code in this online editor and run it.
import random
import math

winwidth=800
winheight=600

x_root = winwidth/2
y_root = winheight/2

n = 17

##################
x_str = str()
y_str = str()
x_str = x_str + "int x[] = {"
y_str = y_str + "int y[] = {"
xy_str = "int xy[] = {"
x_list = []
y_list = []

for i in range(0,n):
    x_cur = x_root + random.randint(int(winwidth/5),int(winwidth/3))*math.cos(i*math.pi/n)
    y_cur = y_root + random.randint(int(winwidth/5),int(winheight/3))*math.sin(i*math.pi/n)
    x_list.append(int(x_cur))
    y_list.append(int(y_cur))

for i in range(0,n):
    x_str += str(x_list[i]) + ", "
    y_str += str(y_list[i]) + ", "
    xy_str+= str(x_list[i]) + ", " + str(y_list[i]) + ", "

x_str += str(x_list[0])
y_str += str(y_list[0])
xy_str+= str(x_list[0]) + ", " + str(y_list[0])

   
x_str += "};"
y_str += "};"
xy_str += "};"

log_file = open("points.log", "w")
log_file.write(x_str+"\n")
log_file.write(y_str+"\n")
log_file.write(xy_str+"\n")
print(x_str)
print("----------------")
print(y_str)
print("----------------")
print(xy_str)