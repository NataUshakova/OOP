using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радицс круга: ");
            double radius = Double.Parse(Console.ReadLine());
            Console.Write("Введите координаты центра круга:\n x = ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write(" y = ");
            double y = Double.Parse(Console.ReadLine());
            Round inst = new Round(radius, x, y);
            Console.WriteLine("Площадь круга = {0}", inst.AreaCircle);
            Console.WriteLine("Длина окружности = {0}", inst.Circumference);
            Console.ReadLine();
        }
    }
}
