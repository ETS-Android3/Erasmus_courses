#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

using namespace std;

// http://sit.tu-varna.bg/discipline/%d0%b3%d1%80%d0%b0%d1%84%d0%b8%d1%87%d0%bd%d0%b8-%d1%81%d0%b8%d1%81%d1%82%d0%b5%d0%bc%d0%b8/lessons/12-%d1%83%d0%bf%d1%80%d0%b0%d0%b6%d0%bd%d0%b5%d0%bd%d0%b8%d1%8f/

#define POINTS_NUM 100
#define AXIS_LABELS 5
int main(){
    // chart root point (left-down corner of the window)
    int x0, y0, dx, dy;
    x0 = 200;    y0 = 550;
    // size of the chart axis
    dx = 700;   dy = 500;
    float x[POINTS_NUM], y[POINTS_NUM], maxX, minX, maxY, minY;

    initwindow(950, 600, "Example");
    
    for(int i=0; i<POINTS_NUM; i++){
        x[i] = i*6-500;
        y[i] = x[i]*x[i]*2 - 5.3*x[i]*x[i]*x[i]*x[i]*x[i] -60;
        std::cout << "i: " << i << " x: " << x[i] << "\t y: " << y[i] << std::endl;
    } 

    maxX = x[0]; minX = x[0]; maxY = y[0]; minY = y[0];
    for(int i=0; i<POINTS_NUM; i++){
        if(x[i]<minX) minX = x[i];
        if(y[i]<minY) minY = y[i];
        if(x[i]>maxX) maxX = x[i];
        if(y[i]>maxY) maxY = y[i];            
    }



    float sx, sy;
    // scale coefficient of the X axis
    sx = (maxX-minX)/dx;    sy =  (maxY-minY)/dy;

    int xp[POINTS_NUM], yp[POINTS_NUM];
    for(int i=0; i<POINTS_NUM; i++){
        xp[i] = x0 + ((x[i]-minX)/sx);
        yp[i] = y0 - ((y[i]-minY)/sy);
        // std::cout << "i: " << i << " xp: " << xp[i] << "\t yp: " << yp[i] << std::endl;
    }


    line(x0,y0, x0,     y0-dy);
    line(x0,y0, x0+dx,  y0);
    for(int i=0; i<POINTS_NUM; i++){
        circle(xp[i],yp[i],3);
        if(i>0){
            line(xp[i-1], yp[i-1], xp[i], yp[i]);
        }
    }

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
