using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class User
    {
        private string surname;
        private string name;
        private string middleName;
        private DateTime dateOfBirth;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }
        //Возраст
        public int GetAge
        {
            get
            {
                DateTime dateNow = DateTime.Now;
                int year = dateNow.Year - dateOfBirth.Year;
                if (dateNow.Month < dateOfBirth.Month ||
                    (dateNow.Month == dateOfBirth.Month && dateNow.Day < dateOfBirth.Day)) year--;
                return year;
            }
        }

        public User() { }

    }
}
