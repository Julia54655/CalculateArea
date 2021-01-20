using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Triangle:IFigure
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle()
        {
            A = B = C = default(double);

        }
        public Triangle(double a,double b,double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double Area
        {
            get
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            }
        }

        public bool IsRectangular()
        {
            return (A == Math.Sqrt(Math.Pow(B, 2) + Math.Pow(C, 2))
                || B == Math.Sqrt(Math.Pow(A, 2) + Math.Pow(C, 2))
                || C== Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2)));
        }
    }
}
