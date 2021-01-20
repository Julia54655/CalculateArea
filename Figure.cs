using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea
{
    public class Figure:IFigure
    {
        private IFigure _Figure;

        public Figure(IFigure figure)
        {
            _Figure = figure;

        }
        public double Area
        {
            get { return _Figure.Area; }
        }

    }
}
