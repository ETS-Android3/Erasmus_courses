# Online Python compiler (interpreter) to run Python online.
# Write Python 3 code in this online editor and run it.
import random
import math

winwidth=600
winheight=600

x_root = winwidth/2
y_root = winheight - winheight/2
# y_root = 200

window_scaling_radius = 1/15

min_x_range = (winwidth*window_scaling_radius)*2
max_x_range = (winwidth*window_scaling_radius)*3
min_y_range = (winheight*window_scaling_radius)
max_y_range = (winheight*window_scaling_radius)*3

n = 34

##################
x_str = str()
y_str = str()
x_str = x_str + "int x[] = {"
y_str = y_str + "int y[] = {"
xy_str = "int xy[] = {"
x_list = []
y_list = []

for i in range(0,n):
    x_cur = x_root + random.randint(int(min_x_range),int(max_x_range))*math.cos(float(i)*2*math.pi/float(n))
    y_cur = y_root + random.randint(int(min_y_range),int(max_y_range))*math.sin(float(i)*2*math.pi/float(n))
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