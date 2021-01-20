using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculateArea
{
    public class Circle:IFigure
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = default(double);
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area
        {
            get {return  Math.PI * Math.Pow(Radius, 2); }
        }




    }
}
