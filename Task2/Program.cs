using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bls = true;
            while (bls)
            {
                Console.Write("Введите длины сторон треугольника:\n a = ");
                double a = Double.Parse(Console.ReadLine());
                Console.Write(" b = ");
                double b = Double.Parse(Console.ReadLine());
                Console.Write(" c = ");
                double c = Double.Parse(Console.ReadLine());
                if (a + b < c || a + c < b || c + b < a)
                {
                    Console.WriteLine("Неправильно заданы стороны");
                    bls = true;
                }
                else
                {
                    Triangle inst = new Triangle(a, b, c);
                    Console.WriteLine("Периметр треугольника = {0}", inst.GetPerimeter);
                    Console.WriteLine("Площадь треугольника = {0}", inst.GetArea);
                    bls = false;
                }

            }

            Console.ReadLine();

        }
    }
}
