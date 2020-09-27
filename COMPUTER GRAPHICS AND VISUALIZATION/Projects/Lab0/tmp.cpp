#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

using namespace std;

void draw_landscape(){
    setfillstyle(1, LIGHTBLUE);
    bar(0, 0, getmaxx(), getmaxy());
    //settextstyle(4, 0, 5);
    //char text[100] = "And this is how we Roll";
    //outtextxy(20, 20, text);
    setfillstyle(1,DARKGRAY);
    bar(0, getmaxy() - 250, getmaxx(), getmaxy());
    //setfillstyle(1, 15);
    //bar(0, getmaxy() - 175, getmaxx(), getmaxy() - 185);
}
int main(){
    std::cout << "Hello World!";
    initwindow(1024, 768, "Example");
    int initial_x = 20;
    int initial_y = getmaxy() - 280;
    draw_landscape();
    getch();


    return 0;
}
