#include <cstdlib>
#include <iostream>
#include <graphics.h>
#include <conio.h>
#include <math.h>
#include <cmath>
#include <stdlib.h>
#include <stdio.h>

using namespace std;

#define NUMBER_OF_POINTS 12


class MyChart {
    private:
        enum MinMax { min_x, max_x, min_y, max_y, min_max_length};
        int x0, y0; // chart root point (left-down corner of the window)
        int dx, dy; // size of the chart axis
        float sx, sy;  // scale coefficient of the X axis

    public:
        int px, py; // size of the chart window
        int data_series1[NUMBER_OF_POINTS*2];
        int data_series_1_min_max[min_max_length];
    
        MyChart() {
            // chart root point (left-down corner of the window)
            x0 = 50;    y0 = 50;

            // size of the chart window
            px = 800;   py = 600;
            
            // size of the chart axis
            dx = px-2*x0;   dy = py-2*y0;

            // scale coefficient of the X axis
            sx = 0;    sy = 0;
        }

        void print_coordinates();
        void fill_data(int values_array[], int val_len);
        void print_data_series(int values_array[], int val_len);
        void calculate_min_max(int values_array[], int val_len, int min_max_array[]);
        void print_data_min_max(int min_max_array[]);
        void calculate_scale_coefficient(int min_max_array[]);
        void print_scale_coefficient();
        void draw_axis();
        void move_coursor_to_chart_root(){
            moveto(x0, py-y0);
        }
};

void MyChart::fill_data(int values_array[], int val_len){
    for(int idx=0 ; idx<val_len; idx+=2){
        int i = idx/2;
        values_array[idx] =  i;
        values_array[idx+1] = i*i*3+i*2-5;
    }
}

void MyChart::print_data_series(int values_array[], int val_len){
    for(int i=0 ; i<val_len; i+=2){
        std::cout << "x: " << values_array[i] << "\ty: " << values_array[i+1] << std::endl;
    }
}

void MyChart::print_coordinates(){
    std::cout << "x0: " << x0 << "\t y0: " << y0 << "\t" << "chart root point (left-down corner of the window)" << std::endl;
    std::cout << "px: " << px << "\t py: " << py << "\t" << "size of the chart window" << std::endl;
    std::cout << "dx: " << dx << "\t dy: " << dy << "\t" << "size of the chart axis" << std::endl;
}

void MyChart::print_data_min_max(int min_max_array[]){
    std::cout << "X min: " << min_max_array[min_x] << "\t X max: " << min_max_array[max_x] << std::endl;
    std::cout << "Y min: " << min_max_array[min_y] << "\t Y max: " << min_max_array[max_y] << std::endl;
}

void MyChart::calculate_min_max(int values_array[], int val_len, int min_max_array[]){
    min_max_array[min_x] = INT_MAX;
    min_max_array[min_y] = INT_MAX;
    min_max_array[max_x] = INT_MIN;
    min_max_array[max_y] = INT_MIN;
    for(int idx=0 ; idx<val_len; idx++){

        if (idx%2){  // calculate for Y
            if(values_array[idx] > min_max_array[max_y])
                min_max_array[max_y] = values_array[idx];
            if(values_array[idx] < min_max_array[min_y])
                min_max_array[min_y] = values_array[idx];
        } else {     // calculate for X
            if(values_array[idx] > min_max_array[max_x])
                min_max_array[max_x] = values_array[idx];
            if(values_array[idx] < min_max_array[min_x])
                min_max_array[min_x] = values_array[idx];
        }
    }
}

void MyChart::calculate_scale_coefficient(int min_max_array[]){
    sx = (float)(min_max_array[max_x] - min_max_array[min_x])/(float)px;    
    sy = (float)(min_max_array[max_y] - min_max_array[min_y])/(float)py;
}

void MyChart::print_scale_coefficient(){
    std::cout << "sx: " << sx << "\t sy: " << sy << "\t" << "scale coefficient of the X axis" << std::endl;
}

void MyChart::draw_axis(){
    setlinestyle(0, 1, 3);
    move_coursor_to_chart_root();
    circle(x0, py-y0, 5);

    move_coursor_to_chart_root();
    linerel(dx, 0);  // axis X 
    move_coursor_to_chart_root();
    linerel(0, -dy); // axis Y
}


int main(){
    // std::cout << "Hello World!";
    MyChart chart = MyChart();
    initwindow(chart.px, chart.py, "Example");
    std::cout << std::endl; // separator

    chart.print_coordinates(); // print data points
    std::cout << std::endl; // separator

    chart.fill_data(chart.data_series1, NUMBER_OF_POINTS*2);
    chart.print_data_series(chart.data_series1, NUMBER_OF_POINTS*2); // print data points
    std::cout << std::endl; // separator

    chart.calculate_min_max(chart.data_series1, NUMBER_OF_POINTS*2, chart.data_series_1_min_max);
    chart.print_data_min_max(chart.data_series_1_min_max);
    std::cout << std::endl; // separator

    chart.calculate_scale_coefficient(chart.data_series_1_min_max);
    chart.print_scale_coefficient();
    std::cout << std::endl; // separator

    chart.draw_axis();
    getch();
    return 0;
}
