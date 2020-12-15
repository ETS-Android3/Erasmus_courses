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

Histograms
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
Circle diagram

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

## 8. INTERPOLATION AND APPROXIMATION algorithms Classical approach for interpolation and approximation. Polynomial of Lagrang.

* Approach for interpolation
    * Building of function for which is valid f(x[i]) = y[i] about every one i and the function f(x) take "reasonable" value for every x in specified range
    * "reasonable" is dependent from requirements and can be different for different functions/purposes
    * If data are experimental data it can be rationally to interpolate they with smooth function

* Approach for approximation
    * If the data are crude the interpolation can be very difficult or impossible
    * In those situations we can allow function output values to be similar to the experiment value 
    * More general function can be used

* Polynomial of Lagrange
    * Most interpolation and approximation algorithm are built using the linear combination from elemental functions. When the elemental function is polynomial the kind of algorithm is definite from kind of polynomial.
    * Lagrange polynomials are used for polynomial interpolation
    * Main defect is the considerable hesitations can be between neighbors points
    * The important limitation is the data set can not have multiple points with the same x value
    * Algorithm of Lagrange Interpolation

    1. Start
    2. Read Number of Data (n)
    3. Read Data:
    For i = 1 to n
        Read Xi and Yi
    Next i
    4. Read xp
    5. Initialize: yp = 0

    6. For i = 1 to n
        p = 1
        For j =1 to n
        If i ≠ j 
            p = p * (xp - Xj)/(Xi - Xj)
        End If
        Next j
        yp = yp + p * Yi
    Next i

    6. Print yp
    7. Stop

## 10. CURVE OF BEZIE. The geometric algorithm for building of curve of Bezie. The algorithm of Horner.

Polinomial of Bezie
* The algorithm uses the multitude of points of support
* Algorithm gives good results for 3d interpolation
* Closeness curve from the points can be regulated by adding multiple points(of the same coordinates)

Geometric algorithm for building of curve of Bezie:
* It is used when m is smaller than 5

Symbols:
* Pi - Initial points of support 
* Ri - old points of support
* Qi - new points of support

For every t from 0 to 1 with step dt do
begin
    for i from 0 to m Ri =Pi
    n=m
    While n>0 do
    begin
        For i from 0 to n-1 Qi =Ri + t . (Ri+1 - Ri )
        n=n-1
        For i from 0 to n Ri =Qi 
    end
    P(t)= R 0
end

The algorithm of Horner
* It is used when m is larger than 5

Symbols:
* Pi - Initial points of support 
* Ri - old points of support
* Qi - new points of support

For every t from 0 to 0,5 with step dt do
begin
    computing (1-t)^m
    Q0=Pm
    for i from 1 to m do
    begin
        Qi=(t(1-t))Q(i-1)+ C^(m- i)_m * P(m-i)
    end
    P(t)= (1-t)^m*Qm
end
For every t from 0,5 to 1 with step dt do
begin
    computing t^m
    Q0 =P0
    for i from 1 to m do
    begin
        Qi=((1-t)/t)*Q(i-1) + C^i_m*Pi
    end
    P(t)= t^m*Q_m
end


## 11. TWO- DIMENSIONAL TRANSFORMATIONS. Composition.

Symbols:
P(x,y) - old point before transformation
P'(x,y) - new point after transformation

There are 4 basic 2d transformations:
* translation
* scaling
* rotation
* reflection

TRANSLATION
Translation is just adding offset D(dx, dy) to the point P.

P' = P + D

SCALING
To scale object there are needed 3 values:
* Sx scaling coefficient 
* Sy scaling coefficient 
* Pf point of scaling

The vector equation may look like this:
P' = Pf + (P - Pf)*S

Decomposition of equation above:
x' = Pfx + (x - Pfx)*Sx
y' = Pfy + (Y - PfY)*SY

ROTATION
To rotate object there are needed 2 values:
* Pr point(center) of scaling Pr(x,y)
* R rotation matrix
* alpha rotation angle

R = |cos(alpha) -sin(alpha)|
    |sin(alpha)  cos(alpha)|

The vector equation may look like this:
P' = Pr + (Pr - P)*R

Decomposition of equation above:
x' = Prx + (x - Prx)*cos(alpha) - (y - Pry)*sin(alpha)
y' = Pry + (y - Pry)*cos(alpha) + (x - Prx)*sin(alpha)

REFLECTION
A figure created by a reflection is its mirror image in the axis or plane of reflection

Reflection transformation matrix depends of the reflection axis.

For the reflection about the x axis matrix is   |1  0|
                                                |0 -1|

In this example value of x should be multiplied by -1
