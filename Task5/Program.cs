using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bls = true;
            while (bls)
            {
                Console.WriteLine("Какую фигуру создать?\n 1. Линия\n 2. Прямоугольник\n 3. Окружность\n 4. Круг\n 5. Кольцо");
                int index = Int32.Parse(Console.ReadLine());
                Point MyP1 = new Point();
                Point MyP2 = new Point();
                switch (index)
                {
                    case 1:
                        Console.Write("Введите координаты начальной точки линии:\n x1 = ");
                        MyP1.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y1 = ");
                        MyP1.y = Double.Parse(Console.ReadLine());
                        Console.Write("Введите координаты конечной точки линии:\n x2 = ");
                        MyP2.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y2 = ");
                        MyP2.y = Double.Parse(Console.ReadLine());
                        Line MyLine = new Line(MyP1, MyP2);
                        MyLine.ShowInfoOfFigure();
                        break;
                    case 2:
                        Point MyP3 = new Point();
                        Point MyP4 = new Point();
                        Console.Write("Введите координаты вершин прямоугольника (вершины нумеруются по часовой стрелке, начиная с левой вверхней)\n x1 = ");
                        MyP1.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y1 = ");
                        MyP1.y = Double.Parse(Console.ReadLine());
                        Console.Write("\n x2 = ");
                        MyP2.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y2 = ");
                        MyP2.y = Double.Parse(Console.ReadLine());
                        Console.Write("\n x3 = ");
                        MyP3.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y3 = ");
                        MyP3.y = Double.Parse(Console.ReadLine());
                        Console.Write("\n x4 = ");
                        MyP4.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y4 = ");
                        MyP4.y = Double.Parse(Console.ReadLine());

                        Rectangle MyRectangle = new Rectangle(MyP1, MyP2, MyP3, MyP4);
                        MyRectangle.ShowInfoOfFigure();
                        break;
                    case 3:
                        Console.Write("Введите координаты центра окружности: \n x = ");
                        MyP1.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y = ");
                        MyP1.y = Double.Parse(Console.ReadLine());
                        Console.Write("Радиус: \n r = ");
                        double Radius = Double.Parse(Console.ReadLine());
                        Circle MyCircle = new Circle(MyP1, Radius);
                        MyCircle.ShowInfoOfFigure();
                        break;
                    case 4:
                        Console.Write("Введите координаты центра круга: \n x = ");
                        MyP1.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y = ");
                        MyP1.y = Double.Parse(Console.ReadLine());
                        Console.Write("Радиус: \n r = ");
                        double Radius2 = Double.Parse(Console.ReadLine());
                        Round MyRound = new Round(MyP1, Radius2);
                        MyRound.ShowInfoOfFigure();
                        break;
                    case 5:
                        Console.Write("Введите координаты центра кольца: \n x = ");
                        MyP1.x = Double.Parse(Console.ReadLine());
                        Console.Write(" y = ");
                        MyP1.y = Double.Parse(Console.ReadLine());
                        Console.Write("Внешний радиус: \n R = ");
                        double OutRadius = Double.Parse(Console.ReadLine());
                        Console.Write("Внутренний радиус: \n r = ");
                        double InRadius = Double.Parse(Console.ReadLine());
                        Ring MyRing = new Ring(MyP1, OutRadius, InRadius);
                        MyRing.ShowInfoOfFigure();
                        break;
                    default:
                        Console.WriteLine("Введите число от 1 до 5!");
                        break;

                }
                Console.WriteLine("Попробовать еще раз? (y/n)");
                string chr = Console.ReadLine();
                if (chr == "y")
                {
                    bls = true;
                }
                else
                {
                    bls = false;
                }


            }
            Console.ReadLine();

        }
    }
}
