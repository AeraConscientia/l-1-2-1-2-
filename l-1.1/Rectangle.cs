using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l_1._1
{
    class Rectangle                                                                                 // класс Rectangle наследуется от класса Figure
    {
        double length;
        double wide;
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Wide
        {
            get { return wide; }
            set { wide = value; }
        }

        public Rectangle()
        {
            length = 0;
            wide = 0;
        }

        public Rectangle(double length, double wide)
        {
            this.length = length;
            this.wide = wide;
        }

        public double Area(double length, double wide) { return length * wide; }                                               // вычисление площади прямоугольника
        public double Perimeter() { return (length + wide) * 2; }                                    // вычисление периметра прямоугольника
    }// Rectangle
}
