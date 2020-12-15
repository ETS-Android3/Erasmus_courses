#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

// 3. TWO DIMENSIONAL TRANSFORMATIONS. Composition. For example: Input data: coordinates of 17 points of polygon. The program has to obtain the transformation polygon after next transformations: - rotation around third point with angle 120°; - scaling with Sx=2.4 Sy=5 .8 and point of scaling (-120, 160)

#define MAX_POINTS 40

using namespace std;
int main(){
    int winwidth=800,winheight=600;
    int xy[] = {418, 300, 380, 318, 411, 325, 375, 362, 379, 337, 349, 393, 336, 387, 326, 379, 307, 383, 290, 393, 273, 411, 253, 391, 232, 375, 217, 345, 207, 346, 217, 327, 189, 314, 218, 300, 202, 291, 215, 281, 197, 240, 216, 254, 227, 226, 250, 227, 274, 196, 292, 230, 309, 195, 328, 238, 350, 217, 352, 268, 378, 240, 396, 260, 402, 277, 381, 282, 418, 300};
    initwindow(winwidth,winheight);
    int n=(sizeof(xy)/sizeof(xy[0]))/2;
    
    // white
    setcolor(15);
    drawpoly(n, xy);

    // rotation
    int rot_idx = 13;
    float rot_angle_deg = -90.0;
    float rot_angle_rad = rot_angle_deg*M_PI/(float)180;
    int rot_root_x = xy[(rot_idx-1)*2];
    int rot_root_y = xy[(rot_idx-1)*2+1];
    int xyp[MAX_POINTS*2];

    for(int i = 0; i< n; i++) {
        float xp_val = (float)rot_root_x + ((float)xy[i*2] - (float)rot_root_x)*cos(rot_angle_rad) - ((float)xy[i*2+1] - (float)rot_root_y)*sin(rot_angle_rad);
        float yp_val = (float)rot_root_y + ((float)xy[i*2+1] - (float)rot_root_y)*cos(rot_angle_rad) + ((float)xy[i*2] - (float)rot_root_x)*sin(rot_angle_rad);
        xyp[i*2] = (int)xp_val;
        xyp[i*2+1] = (int)yp_val;
    }
    // green
    setcolor(2);
    drawpoly(n, xyp);

    // Scaling
    int scal_root_x = 40, scal_root_y = 60;
    float sx=1.6, sy=0.5;
    int xyb[MAX_POINTS*2];

    for(int i = 0; i< n; i++) {
        float xp_val = (float)scal_root_x + ((float)xyp[i*2] - (float)scal_root_x)*sx;
        float yp_val = (float)scal_root_y + ((float)xyp[i*2+1] - (float)scal_root_y)*sy;
        xyb[i*2] = (int)xp_val;
        xyb[i*2+1] = (int)yp_val;
    }
    // red
    setcolor(4);
    drawpoly(n, xyb);

    // 1st point of polygon - white
    setcolor(15);
    circle(xy[0],xy[1],5);

    // point of rotation - green
    setcolor(2);
    circle(rot_root_x,rot_root_y,5);

    // point of scalling - red
    setcolor(4);
    circle(scal_root_x,scal_root_y,5);
    
    getch();
    return 0;
}