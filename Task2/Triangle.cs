using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Triangle
    {
        //стороны треугольника
        private double a;
        private double b;
        private double c;

        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value > 0)
                    a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value > 0)
                    b = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value > 0)
                    c = value;
            }
        }

        //Периметр
        public double GetPerimeter
        {
            get { return a + b + c; }
        }

        //Площадь
        public double GetArea
        {
            get { return Math.Sqrt((GetPerimeter / 2) * (GetPerimeter / 2 - a) * (GetPerimeter / 2 - c) * (GetPerimeter / 2 - b)); }
        }

        public Triangle(double A0, double B0, double C0)
        {
            a = A0;
            b = B0;
            c = C0;
        }


    }
}
