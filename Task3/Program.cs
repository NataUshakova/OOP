using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            User human = new User();
            Console.Write("Введите данные пользователя.\n Фамилия: ");
            human.Surname = Console.ReadLine();
            Console.Write(" Имя: ");
            human.Name = Console.ReadLine();
            Console.Write(" Отчество: ");
            human.MiddleName = Console.ReadLine();
            Console.Write(" Дата рождения: ");
            human.DateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(" Возраст пользователя {0} составляет {1} лет (года)", human.Name, human.GetAge);
            Console.ReadLine();
        }
    }
}
