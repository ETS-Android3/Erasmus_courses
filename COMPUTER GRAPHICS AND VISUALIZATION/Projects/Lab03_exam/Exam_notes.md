# Exam notes:

## 6. TWO- DIMENSIONAL DRAWING. Graphical presentation of experimental data in defined graphical windows

Result of 2d drawing is 2d chart. Input data are list of pairs of coordinates (x, y).

Before drawing chart input data should be known.

1) In first step graphical window should be set:
* Set root of axis coordinates x0, y0(left bottom corner)
* Set size of graphical window: width Px and height Py
* Set size of the axis ADx, ADy
* Set size of the axis grid Dx, Dy

2) Find min and max of values (minX, maxX, minY, maxY)

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

5) Compute coordinates of points according to real data and size of window and draw them
for i in range(0, number of points)
    xp[i] = x0 + ((x[i]-minX)/Sx);
    yp[i] = y0 - ((y[i]-minY)/Sy);
end for


## 7. THE ECONOMIC GRAPHICS, Histograms and circle diagrams
Histograms and circle diagrams are often used to economical,
statistical and sociological information
### Histograms
Histogram presents data as set of vertical or horizontal bars. Bars can be presented in different colors to achieve for better clarity.

Data set should be list of objects that contains value and description of value.
Before drawing chart input data should be known.

1) In first step graphical window should be set:
* Set root of axis coordinates x0, y0(left bottom corner)
* Set size of graphical window: width Px and height Py
* Set size of the axis ADx, ADy
* Set size of the value axis grid D
* Set size of the text axis grid Ds(gap between bars), Dc(size of bar)
* Set list of colors or pattern if it is needed

* Calculate or set the numbers of bars N and their directions;

2) Find min and max of values (minA, maxA)
To show real value, min or max value can be modified:
* If the minA>0 then minA=0 (scope - (0;maxA))
* If the maxA<0 then maxA=0 (scope - (minA; 0))

3) Compute scale coefficients:
* s = (maxA-minA)/P 
where P is Px(for horizontal) or Py(for vertical) 

4) Draw the axes
* X axis line with points ( x0 ,y0 ) , ( x0 + Px ,y0 )
* Y axis line with points ( x0 ,y0 ) , ( x0 ,y0 − Py )
* calculate number of grid axes labels: Horizontal axis: Ip = ADx/Dx; Vertical axis: Jp = ADy/Dy;

* Draw grid on axes:
    * Horizontal axis
    for i in range(0, Ip)
        line with points ( x0 + i*Dx ,y0 ) , (x0 + i*Dx , y0 + 3) 
        if horizontal bars
            set text under line with value ( minX+ i*Dx*Sx )
        else
            set text of data label under bar ( x0 + i*( Ds + Dc ) − Dc ,y0 ) , ( x0 + i*( Ds + Dc ),y0 ) 
        endif
    end for

    * Vertical axis
    for j in range(0, Jp)
        line with points ( x0 ,y0 − j*Dy ) ( x0 − 3,y0 − j*Dy )
        if vertical bars
            set text next to line with value ( minY+ i*Dy*Sy )
        else
            set text of data label under bar ( x0 ,y0 − i*( Ds + Dc ) ) + Dc ) , ( x0 ,y0 − i*( Ds + Dc ) − Dc ) 
        endif
    end for

5) Compute coordinates of points(2 corner of bars) according to real data and size of window and draw them
* vertical bars:
    for i in range(0, number of bars)
        top left corner ( x0 + i*(Ds + Dc) - Dc , y0 - (a[i] - minA)/S)
        bottom right corner (x0 + i *(Ds + Dc), y0 )
    end for
* horizontal bars:
    for i in range(0, number of bars)
        top left corner (x0, y0 - i *(Ds + Dc) )
        bottom right corner ( x0 + (a[i] - minA)/S) , y0 - i*(Ds + Dc) - Dc )

    end for
### Circle diagram

Presents data as a part of circle. It can be used for display percentage distribution of values.

Data set should be list of objects that contains value and description of value.
Before drawing chart input data should be known.

1) In first step graphical window should be set:
* Set size of graphical window: width Px and height Py
* Set coordinates of the center of the circle x0, y0
* Set radius of Circle - R or radius of the ellipse - Rx and Ry
* Set list of colors or pattern if it is needed

2) Compute angles of sectors
* Sum all data A = sum of all
* Calculate angle of sector alpha[i] = (2*PI*a[i])/A

* Calculate coordinates of sectors points
    x[i] = x0 + Rx*cos(sum of alphas so far)
    y[i] = y0 + Ry*sin(sum of alphas so far)
    if figure is circle then Rx and Ry equals R

* Draw all sectors with method pieslice

