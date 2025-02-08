#include "Square.h"
#include <cmath>

Square::Square()
: x1(0), y1(0), x2(0), y2(0), x3(0), y3(0), x4(0), y4(0)
{
}

Square::Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
: x1(x1), y1(y1), x2(x2), y2(y2), x3(x3), y3(y3), x4(x4), y4(y4)
{
}

//setters
void Square::setCoordinates(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4)
{
    x1 = X1;
    y1 = Y1;
    x2 = X2;
    y2 = Y2;
    x3 = X3;
    y3 = Y3;
    x4 = X4;
    y4 = Y4;
}

//getters
double Square::getX1() const {return x1;}
double Square::getY1() const {return y1;}
double Square::getX2() const {return x2;}
double Square::getY2() const {return y2;}
double Square::getX3() const {return x3;}
double Square::getY3() const {return y3;}
double Square::getX4() const {return x4;}
double Square::getY4() const {return y4;}

double Square::resPerimeter() const
{
    double side1 = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
    double side2 = sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2));
    double side3 = sqrt(pow(x4 - x3, 2) + pow(y4 - y3, 2));
    double side4 = sqrt(pow(x1 - x4, 2) + pow(y1 - y4, 2));
    return side1 + side2 + side3 + side4;
}

double Square::resArea() const
{
    double side1 = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
    double side2 = sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2));
    return side1 * side2;
}
bool Square::isSquare() const
{
    double side1 = sqrt(pow(x2 - x1, 2) + pow(y2 - y1, 2));
    double side2 = sqrt(pow(x3 - x2, 2) + pow(y3 - y2, 2));
    double side3 = sqrt(pow(x4 - x3, 2) + pow(y4 - y3, 2));
    double side4 = sqrt(pow(x1 - x4, 2) + pow(y1 - y4, 2));
    return side1 == side2 && side2 == side3 && side3 == side4;
}