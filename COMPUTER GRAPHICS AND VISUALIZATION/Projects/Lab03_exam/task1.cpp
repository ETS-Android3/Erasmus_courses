#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

// 1. Graphical presentation of experimental data in defined graphical windows For example: The program have to obtain graphical presentation function: y=x2+5sinx for -2≤x≤2 in gr. window. Gr. Window (x0,y0)=(50,400), Rx=300, Py=250

#define POINTS_NUM 50
#define AXIS_LABELS 5
#define MIN_X_RANGE -2
#define MAX_X_RANGE 2

using namespace std;
int main(){
    // chart root point (left-down corner of the window)
    int x0, y0, dx, dy;
    x0 = 50;    y0 = 400;
    // size of the chart axis
    dx = 300;   dy = 250;
    float x[POINTS_NUM], y[POINTS_NUM], maxX, minX, maxY, minY;

    initwindow(dx+100, y0+50, "Example");
    
    // assign values
    for(int i=0; i<POINTS_NUM; i++){
        x[i] = MIN_X_RANGE+i*((float)(MAX_X_RANGE-MIN_X_RANGE)/(float)(POINTS_NUM-1));
        y[i] = x[i]*x[i] + 5.0*sin(x[i]);
        // std::cout << "i: " << i << " x: " << x[i] << "\t y: " << y[i] << std::endl;
    } 

    // calculate min and max
    maxX = x[0]; minX = x[0]; maxY = y[0]; minY = y[0];
    for(int i=0; i<POINTS_NUM; i++){
        if(x[i]<minX) minX = x[i];
        if(y[i]<minY) minY = y[i];
        if(x[i]>maxX) maxX = x[i];
        if(y[i]>maxY) maxY = y[i];            
    }
    // std::cout << "maxX: " << maxX << " minX: " << minX << "\t maxY: " << maxY << " minY: " << minY << std::endl;



    float sx, sy;
    // scale coefficient of the X axis
    sx = (maxX-minX)/dx;    sy =  (maxY-minY)/dy;

    int xp[POINTS_NUM], yp[POINTS_NUM];
    for(int i=0; i<POINTS_NUM; i++){
        xp[i] = x0 + ((x[i]-minX)/sx);
        yp[i] = y0 - ((y[i]-minY)/sy);
        // std::cout << "i: " << i << " xp: " << xp[i] << "\t yp: " << yp[i] << std::endl;
    }


    // draw axis line
    int x0n=x0;
    if (minX<0) x0n=x0+(0-minX)/sx;
    int y0n=y0;
    if (minY<0) y0n=y0-(0-minY)/sy;

    line(x0n, y0,  x0n,  y0-dy);
    line(x0,  y0n, x0+dx,  y0n);

    // draw points and connections between
    for(int i=0; i<POINTS_NUM; i++){
        circle(xp[i],yp[i],3);
        if(i>0){
            line(xp[i-1], yp[i-1], xp[i], yp[i]);
        }
    }

    // axis description
    int x_axis_sep = dx/AXIS_LABELS;
    int y_axis_sep = dy/AXIS_LABELS;
    for(int i=0; i<AXIS_LABELS+1; i++){
        char text[20];
        float x_desc, y_desc;
        line(x0+x_axis_sep*i, y0, x0+x_axis_sep*i, y0+10 );
        x_desc = minX+(i*sx*dx)/AXIS_LABELS;
        sprintf(text, "%.2f",x_desc);
        settextjustify(2,2);
        outtextxy(x0+x_axis_sep*i,y0+15, text);

        line(x0, y0-y_axis_sep*i, x0-10, y0-y_axis_sep*i );
        y_desc = minY+(i*sy*dy)/AXIS_LABELS;
        sprintf(text, "%.2f",y_desc);
        settextjustify(2,1);
        outtextxy(x0-15,y0-y_axis_sep*i, text);
    }

    getch();
    return 0;
}