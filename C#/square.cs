using System;

namespace SquareProg
{
    public class Square
    {
        private double x1, y1;
        private double x2, y2;
        private double x3, y3;
        private double x4, y4;

        public Square()
        {
            x1 = y1 = x2 = y2 = x3 = y3 = x4 = y4 = 0.0;
        }
        public Square(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;

        }
        public void SetCoordinates(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
        //make getters
        public double X1 => x1;
        public double Y1 => y1;
        public double X2 => x2;
        public double Y2 => y2;
        public double X3 => x3;
        public double Y3 => y3;
        public double X4 => x4;
        public double Y4 => y4;
    
    public bool CheckEqualSides()
    {
            double[] sides = new double[4]
            {
                Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),
                Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)),
                Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2)),
                Math.Sqrt(Math.Pow(x1 - x4, 2) + Math.Pow(y1 - y4, 2))
            };

            return sides.All(side => side == sides[0]);
    }
        public double ResPerimeter()
        {
            double sideA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            return sideA * 4;
        }
        public double ResArea()
        {
            double sideA = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
            return sideA * sideA;
        }
    }
}