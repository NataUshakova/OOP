using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee human = new Employee();
            Console.Write("Введите данные пользователя:\n Фамилия: ");
            human.Surname = Console.ReadLine();
            Console.Write(" Имя: ");
            human.Name = Console.ReadLine();
            Console.Write(" Отчество: ");
            human.MiddleName = Console.ReadLine();
            Console.Write(" Дата рождения: ");
            human.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.Write(" Стаж работы: ");
            human.WorkExperience = Console.ReadLine();
            Console.Write(" Должность: ");
            human.Position = Console.ReadLine();
            Console.WriteLine();
            human.GetInfo();
            Console.ReadLine();
        }
    }
}
