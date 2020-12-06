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
    int xy[] = {200, 200, 227, 212, 191, 227, 250, 240, 234, 253, 183, 232, 195, 245, 180, 306, 153, 263, 140, 259, 135, 239, 112, 285, 81, 251, 117, 235, 59, 256, 88, 231, 93, 215, 200, 200};
    initwindow(winwidth,winheight);
    int n=(sizeof(xy)/sizeof(xy[0]))/2;
    // std::cout << "n: " << n << std::endl;
    
    // white
    setcolor(15);
    drawpoly(n, xy);

    // rotation
    int rot_idx = 1;
    float rot_angle_deg = 120.0;
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
    int scal_root_x = -120, scal_root_y = 160;
    float sx=2.4, sy=5.8;
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

    getch();
    return 0;
}