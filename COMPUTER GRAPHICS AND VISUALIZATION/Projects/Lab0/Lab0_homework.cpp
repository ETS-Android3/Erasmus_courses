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
    // Text on the wings settings
    char wing_text[16] = "Wing X";
    int text_justify_h[] = {CENTER_TEXT, LEFT_TEXT,    RIGHT_TEXT,  RIGHT_TEXT };
    int text_justify_v[] = {BOTTOM_TEXT, VCENTER_TEXT, BOTTOM_TEXT, TOP_TEXT   };
    
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
    // Put text on the wing
    for(int i=0 ; i<4; i++){
        circle(wing_x[i], wing_y[i], 3); // helper to see a center of the wing
        
        settextstyle(GOTHIC_FONT, 0, 2);
        sprintf(wing_text, "Wing %d", i);
        settextjustify(text_justify_h[i], text_justify_v[i]);
        outtextxy(wing_x[i], wing_y[i], wing_text);
    }
    
    // Comment: 
    //  * vertical centring alignment of the text at the wing 1 not works as I expected(it looks like bottom alignment)  
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
