using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Rectangle : Line
    {
        //Добавление двух вершин
        private Point p3, p4;
        public Point P3
        {
            get
            {
                return p3;
            }
            set
            {
                p3 = value;
            }
        }
        public Point P4
        {
            get
            {
                return p4;
            }
            set
            {
                p4 = value;
            }
        }

        //Длина прямоугольника
        public double GetLenght
        {
            get
            {
                return Math.Abs(P1.x - P2.x);
            }
        }
        //Ширина прямоугольника
        public double GetWight
        {
            get
            {
                return Math.Abs(P1.y - P4.y);
            }
        }
        //Площадь прямоугольника
        public double GetArea
        {
            get
            {
                return GetLenght * GetWight;
            }
        }
        //Периметр прямоугольника
        public double GetPerimetr
        {
            get
            {
                return 2 * (GetLenght + GetWight);
            }
        }

        public Rectangle(Point p1, Point p2, Point p3, Point p4) : base(p1, p2)
        {
            P3 = p3;
            P4 = p4;
        }

        public override void ShowInfoOfFigure()
        {
            Console.WriteLine("Фигура: Прямоугольник");
            Console.WriteLine(" Координаты вершин прямоугольника:\n  ({0},{1}), ({2},{3}), ({4},{5}), ({6},{7})", P1.x, P1.y, P2.x, P2.y, P3.x, P3.y, P4.x, P4.y);
            Console.WriteLine(" Ширина = {0}\n Длина = {1}", GetWight, GetLenght);
            Console.WriteLine(" Площадь = {0}\n Периметр = {1}", GetArea, GetPerimetr);
        }
    }
}
