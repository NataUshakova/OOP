using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Circle : IFigure
    {
        //Центр и радиус окружности
        protected Point centre;
        protected double radius;

        public Point Centre
        {
            get
            {
                return centre;
            }
            set
            {
                centre = value;
            }
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value > 0)
                    radius = value;
            }
        }
        //Длина окружности
        public double Circumference
        {
            get
            {
                return 2 * Math.PI * Radius;
            }
        }

        public Circle(Point Centre, double Radius)
        {
            this.Centre = Centre;
            this.Radius = Radius;
        }

        public virtual void ShowInfoOfFigure()
        {
            Console.WriteLine("Фигура: Окружность");
            Console.WriteLine(" Центр окружности в точке ({0},{1})\n Радиус = {2}", Centre.x, Centre.y, Radius);
            Console.WriteLine(" Длина окружности = {0}", Circumference);
        }
    }
}
