using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Ring : Round
    {
        //Добавление внутреннего радиуса
        private double inRadius;
        public double InRadius
        {
            get
            {
                return inRadius;
            }
            set
            {
                if (value < Radius)
                    inRadius = value;
            }
        }
        //Площадь кольца
        public double GetAreaRing
        {
            get
            {
                return GetAreaRound - Math.PI * InRadius * InRadius;
            }
        }
        //Длина внутренней окружности
        public double InCircumference
        {
            get
            {
                return 2 * Math.PI * InRadius;
            }
        }

        public Ring(Point Centre, double Radius, double InRadius) : base(Centre, Radius)
        {
            this.InRadius = InRadius;
            this.Centre = Centre;
            this.Radius = Radius;
        }


        public override void ShowInfoOfFigure()
        {
            Console.WriteLine("Фигура: Кольцо");
            Console.WriteLine(" Центр кольца в точке ({0},{1})\n Внешний радиус R = {2} \n Внутренний радиус r = {3}", Centre.x, Centre.y, Radius, InRadius);
            Console.WriteLine(" Длина внешней окружности = {0}", Circumference);
            Console.WriteLine(" Длина внутренней окружности = {0}", InCircumference);
            Console.WriteLine(" Площадь кольца = {0}", GetAreaRing);
        }




    }
}

