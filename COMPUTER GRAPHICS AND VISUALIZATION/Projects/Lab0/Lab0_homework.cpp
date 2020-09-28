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
    // draw wings settings
    int arc_x[] =       {200,   400,    400,    200};
    int arc_y[] =       {200,   200,    400,    400};
    int arc_sangle[] =  {-135,  -225,   45,     315};
    int arc_eangle[] =  {45,    -45,   -135,    135};
    // color of the wings settings
    int wing_x[] =      {300,   400,    300,    200};
    int wing_y[] =      {200,   300,    400,    300};
    int wing_color[] =  {BLUE,  GREEN,  CYAN,   RED};
    
    // draw arcs of the wings
    for(int i=0 ; i<4; i++){
        setlinestyle(0, 1, 3);
        setfillstyle(1, wing_color[i]);
        arc(arc_x[i], arc_y[i], arc_sangle[i], arc_eangle[i], 141);
    }
    // fill the wings with colour
    for(int i=0 ; i<4; i++){
        setfillstyle(1, wing_color[i]);
        floodfill(wing_x[i], wing_y[i], getcolor());
    }
    // bar(0, 0, getmaxx(), getmaxy());
    //settextstyle(4, 0, 5);
    //char text[100] = "And this is how we Roll";
    //outtextxy(20, 20, text);
    // setfillstyle(1,DARKGRAY);
    // bar(0, getmaxy() - 250, getmaxx(), getmaxy());
    //setfillstyle(1, 15);
    //bar(0, getmaxy() - 175, getmaxx(), getmaxy() - 185);
}
int main(){
    // std::cout << "Hello World!";
    initwindow(600, 600, "Example");
    int initial_x = 200;
    int initial_y = 200;
    draw_landscape();
    getch();


    return 0;
}
