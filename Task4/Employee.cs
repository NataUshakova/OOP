using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;

namespace Task4
{
    class Employee : User
    {
        //стаж
        private string workExperience;
        //должность
        private string position;

        public string WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public void GetInfo()
        {
            Console.WriteLine("\nВсе данные о сотруднике: \n\n Фамилия: {0} \n Имя: {1} \n Отчество: {2} \n Дата рождения: {3} \n Возраст: {4} \n Стаж работы: {5} \n Должность: {6} \n", this.Surname, this.Name, this.Surname, this.DateOfBirth.ToLongDateString(), this.GetAge, this.WorkExperience, this.Position);
        }

    }
}
