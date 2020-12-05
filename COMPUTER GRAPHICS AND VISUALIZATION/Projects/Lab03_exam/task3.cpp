#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

// 3. TWO DIMENSIONAL TRANSFORMATIONS. Composition. For example: Input data: coordinates of 17 points of polygon. The program has to obtain the transformation polygon after next transformations: - rotation around third point with angle 120°; - scaling with Sx=2.4 Sy=5 .8 and point of scaling (-120, 160)

#define MAX_POINTS 20

using namespace std;
int main(){
    int winwidth=800,winheight=600;
    int xy[] = {651, 300, 576, 331, 562, 365, 621, 397, 589, 432, 548, 458, 485, 451, 456, 478, 424, 462, 383, 465, 327, 492, 316, 459, 282, 443, 234, 407, 261, 385, 245, 362, 236, 331, 651, 300};
    // int xyp[] = {651, 300, 576, 331, 562, 365, 621, 397, 589, 432, 548, 458, 485, 451, 456, 478, 424, 462, 383, 465, 327, 492, 316, 459, 282, 443, 234, 407, 261, 385, 245, 362, 236, 331, 651, 300};
    initwindow(winwidth,winheight);
    int n=(sizeof(xy)/sizeof(xy[0]))/2;
    std::cout << "n: " << n << std::endl;
    

    drawpoly(n, xy);

    // rotation
    int rot_idx = 3;
    float rot_angle = 120.0;
    int rot_root_x = xy[(rot_idx-1)*2];
    int rot_root_y = xy[(rot_idx-1)*2+1];
    int xyp[MAX_POINTS*2];

    for(int i = 0; i< n; i++) {
        xyp[i*2] = rot_root_x + (xy[i*2] - rot_root_x)*cos(rot_angle*M_PI/(float)180) - (xy[i*2] - rot_root_x)*sin(rot_angle*M_PI/(float)180);
        xyp[i*2+1] = rot_root_y + (xy[i*2+1] - rot_root_y)*sin(rot_angle*M_PI/(float)180) + (xy[i*2+1] - rot_root_y)*cos(rot_angle*M_PI/(float)180);
    }
    setcolor(5);
    drawpoly(n, xyp);


    // int ax = 250, ay = 500, a = 160, i;
    // int bx=ax+a;
    // int by=ay;
    // int cx=ax+a;
    // int cy=ay-a;
    // int dx=ax;
    // int dy=ay-a;
    // int mx=ax+a/2;
    // int my=ay-3./2*a;

    // rectangle(dx,dy,bx,by);
    // line(dx,dy,mx,my);
    // line(mx,my,cx,cy);
    // delay(500);

    // double sx = 1.2, sy = 0.7;
    // int dxm = mx+ (dx-mx)*sx;
    // int dym = my+ (dy-my)*sy;

    // int bxm = mx+ (bx-mx)*sx;
    // int bym = my+ (by-my)*sy;

    // int axm = mx+ (ax-mx)*sx;
    // int aym = my+ (ay-my)*sy;
    // int cxm = mx+ (cx-mx)*sx;
    // int cym = my+ (cy-my)*sy;

    // rectangle(dxm,dym,bxm,bym);
    // line(dxm,dym,mx,my);
    // line(mx,my,cxm,cym);
    // delay(500);
    // cleardevice();

    // for(i=1;i<=360;i+=360)
    // {
    //     int axr = mx + (axm - mx)*cos(i*M_PI/180) - (aym - my)*sin(i*M_PI/180);
    //     int ayr = my + (axm - mx)*sin(i*M_PI/180) + (aym - my)*cos(i*M_PI/180);
    //     int bxr = mx + (bxm - mx)*cos(i*M_PI/180) - (bym - my)*sin(i*M_PI/180);
    //     int byr = my + (bxm - mx)*sin(i*M_PI/180) + (bym - my)*cos(i*M_PI/180);
    //     int cxr = mx + (cxm - mx)*cos(i*M_PI/180) - (cym - my)*sin(i*M_PI/180);
    //     int cyr = my + (cxm - mx)*sin(i*M_PI/180) + (cym - my)*cos(i*M_PI/180);
    //     int dxr = mx + (dxm - mx)*cos(i*M_PI/180) - (dym - my)*sin(i*M_PI/180);
    //     int dyr = my + (dxm - mx)*sin(i*M_PI/180) + (dym- my)*cos(i*M_PI/180);
    //     setcolor(15);
    //     moveto(axr,ayr);
    //     lineto(bxr, byr);
    //     lineto(cxr,cyr);
    //     lineto(dxr,dyr);
    //     lineto(axr,ayr);
    //     line(mx, my, cxr, cyr);
    //     line(mx, my, dxr, dyr);
    //     delay(40);
    // }
    getch();
    return 0;
}