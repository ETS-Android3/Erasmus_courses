# Exam notes:

## 6. TWO- DIMENSIONAL DRAWING. Graphical presentation of experimental data in defined graphical windows

Result of 2d drawing is 2d chart. Input data are list of pairs of coordinates (x, y).

Before drawing chart input data should be known.

1) In first step graphical window should be set:
* Set root of axis coordinates x0, y0(left bottom corner)
* Set size of graphical window: width Px and height Py
* Set size of the axis ADx, ADy
* Set size of the axis grid Dx, Dy

2) Find min and max of coordinates (minX, maxX, minY, maxY)

3) Compute scale coefficients:
* sx = (maxX-minX)/Px 
* sy = (maxY-minY)/Py 

4) Draw axes:
* X axis line with points ( x0 ,y0 ) , ( x0 + Px ,y0 )
* Y axis line with points ( x0 ,y0 ) , ( x0 ,y0 − Py )
* calculate number of axes labels: Horizontal axis: Ip = ADx/Dx; Vertical axis: Jp = ADy/Dy;

* Draw grid on axes:
    * Horizontal axis
    for i in range(0, Ip)
        line with points ( x0 + i*Dx ,y0 ) , (x0 + i*Dx , y0 + 3) 
        set text under line with value ( minX+ i*Dx*Sx )
    end for

    * Vertical axis
    for j in range(0, Jp)
        line with points ( x0 ,y0 − j*Dy ) ( x0 − 3,y0 − j*Dy )
        set text next to line with value ( minY+ i*Dy*Sy )
    end for

* Compute coordinates of points according to real data and size of window
for i in range(0, number of points)
    xp[i] = x0 + ((x[i]-minX)/Sx);
    yp[i] = y0 - ((y[i]-minY)/Sy);
end for


