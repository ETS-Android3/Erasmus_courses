#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

// 7. THE ECONOMIC GRAPHICS, Histograms and circle diagrams For example: Input data: 3 real data which correspond with financial result of one firm. The program has to obtain graphical presentation of financial result a firm for last 3 months like vertical histograms in gr. window: (x0,y0)=(30,420), Ds=30, Dc=40, Py=300.

#define POINTS_NUM 3
#define AXIS_LABELS 5

using namespace std;
int main(){
    // chart root point (left-down corner of the window)
    int x0, y0, dx, dy;
    x0 = 30;    y0 = 420;
    // size of the chart axis
    dx = 300;   dy = 300;
    float x[POINTS_NUM], y[POINTS_NUM], maxX, minX, maxY, minY;

    initwindow(dx+100, y0+50, "Example");
    
    // assign values
    for(int i=0; i<POINTS_NUM; i++){
        x[i] = i +1;
        y[i] = x[i]*x[i] + 5.0*sin(x[i]);
        // std::cout << "i: " << i << " x: " << x[i] << "\t y: " << y[i] << std::endl;
    } 

    getch();
    return 0;
}