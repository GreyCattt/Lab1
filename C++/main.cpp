#include <iostream>
#include "Square.h"
using namespace std;

int main()
{
    double x1, y1, x2, y2, x3, y3, x4, y4;
    cout << "Enter the coordinates of the square: \n";
    cout << "x1: "; cin >> x1;
    cout << "y1: "; cin >> y1;
    cout << "x2: "; cin >> x2;
    cout << "y2: "; cin >> y2;
    cout << "x3: "; cin >> x3;
    cout << "y3: "; cin >> y3;
    cout << "x4: "; cin >> x4;
    cout << "y4: "; cin >> y4;
    Square square(x1, y1, x2, y2, x3, y3, x4, y4);

    if (square.isSquare())
    {
        cout << "This is a square :D\n";
    }
    else
    {
        cout << "This is not a square -_-\n";
        return 0;
    }

    cout<<"\n Square coordinates: \n";
    cout << " A(" << square.getX1() << ", " << square.getY1() << ")\n";
    cout << " B(" << square.getX2() << ", " << square.getY2() << ")\n";
    cout << " C(" << square.getX3() << ", " << square.getY3() << ")\n";
    cout << " D(" << square.getX4() << ", " << square.getY4() << ")\n";

    double perimeter = square.resPerimeter();
    cout << "Perimeter: " << perimeter << endl;

    double area = square.resArea();
    cout << "Area: " << area << endl;

    return 0;
}