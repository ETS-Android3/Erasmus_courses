#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

// 7. THE ECONOMIC GRAPHICS, Histograms and circle diagrams For example: Input data: 3 real data which correspond with financial result of one firm. The program has to obtain graphical presentation of financial result a firm for last 3 months like vertical histograms in gr. window: (x0,y0)=(30,420), Ds=30, Dc=40, Py=300.

using namespace std;
int main(){
    // chart root point (left-down corner of the window)
    int x0 = 30, y0 = 420;
    float a[] = {10352.12, 4002.53, 26142.86};
    char labels[][20]={"October", "November", "December"};
    int n=sizeof(a)/sizeof(a[0]);

    int Px=300,Py=300,D=100,Ds=30,Dc=40 ;
    int i,x1,y1,x2,y2;
    int winwidth=Px+200,winheight=Py+200;
    initwindow(winwidth, winheight, "Example");

    
    float amin = a[0];
    float amax = a[0];
    for(int i = 1; i< n; i++) {
        if(a[i] < amin) amin = a[i];
        if(a[i] > amax) amax = a[i];
    }

    if (amin>0) amin=0;
    if (amax<0) amax=0;
    float s = (amax - amin)/Py;

    int y0n=y0+amin/s;

    line(x0,y0n,x0+Px,y0n);
    line(x0,y0,x0,y0-Py);
    int I = Py/D; 
    char text[10];

    for(i=0; i<=I; i++)
    {
        line(x0, y0-D*i, x0-3, y0-D*i);
        sprintf(text, "%.2f",amin + i*D*s);
        settextjustify(2,1);
        outtextxy(x0-10,y0-D*i+5, text); 
    }
    for(i=1; i<=n; i++)
    {
        settextjustify(1,2);
        outtextxy(x0+i*(Ds+Dc)-Ds/2,y0+5, labels[i-1]); 
    }
    for(i=1; i<n+1; i++)
    {
        x1=x0+i*(Ds+Dc)-Ds;
        y1=y0n-(a[i-1])/s;
        x2=x0+i*(Ds+Dc);
        y2=y0n;
        setfillstyle(1, i+1);
        bar(x1,y1,x2,y2);
    }


    getch();
    return 0;
}