using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task5
{
    public class Line : IFigure
    {
        //две точки для построения линии
        protected Point p1, p2;
        public Point P1
        {
            get
            {
                return p1;
            }
            set
            {
                p1 = value;
            }
        }
        public Point P2
        {
            get
            {
                return p2;
            }
            set
            {
                p2 = value;
            }
        }
        //Длина линии
        public double GetLengh
        {
            get
            {
                return Math.Sqrt((P2.y - P1.y) * (P2.y - P1.y) + (P2.x - P1.x) * (P2.x - P1.x));
            }
        }

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

        public virtual void ShowInfoOfFigure()
        {
            Console.WriteLine("Фигура: Линия");
            Console.WriteLine(" Начало линии в точке ({0},{1})\n Конец линии в точке ({2},{3})", P1.x, P1.y, P2.x, P2.y);
            Console.WriteLine(" Длина линии = {0}", GetLengh);
        }
    }
}