using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figure
{
    
    internal class Rectangle : Figure, IPaintAble, IDrawAble
    {
        public double calculationSquare(double width, double height)
        {
            return width * height;
        }

        public void paintAble() { }

        public void drawAble() { }
    }
}
