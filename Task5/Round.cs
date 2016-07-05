using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Round : Circle
    {
        //Площадь круга
        public double GetAreaRound
        {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }

        public Round(Point Centre, double Radius) : base(Centre, Radius)
        {
            this.Centre = Centre;
            this.Radius = Radius;
        }

        public override void ShowInfoOfFigure()
        {
            Console.WriteLine("Фигура: Круг");
            Console.WriteLine(" Центр круга в точке ({0},{1})\n Радиус = {2}", Centre.x, Centre.y, Radius);
            Console.WriteLine(" Длина окружности круга = {0}", Circumference);
            Console.WriteLine(" Площадь круга = {0}", GetAreaRound);
        }

    }
}
