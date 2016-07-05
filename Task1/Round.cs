using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task1
{
    class Round
    {
        //радиус
        private double r;
        //координаты центра
        private double x;
        private double y;

        public double R
        {
            get
            {
                return r;
            }
            set
            {
                if (value > 0)
                    r = value;
            }
        }

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        //Площадь круга
        public double AreaCircle
        {
            get { return Math.PI * r * r; }
        }

        //Длина окружности
        public double Circumference
        {
            get { return Math.PI * r * 2; }
        }

        public Round(double Rad, double X0, double Y0)
        {
            r = Rad;
            x = X0;
            y = Y0;
        }
    }
}
