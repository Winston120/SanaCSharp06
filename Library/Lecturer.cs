using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Lecturer : Person
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string University { get; set; }

        public Lecturer(string firstName, string lastName, Date birthday, string jobTitle, string department, string university)
            : base(firstName, lastName, birthday)
        {
            JobTitle = jobTitle;
            Department = department;
            University = university;
        }
        public Lecturer(string firstName, string lastName, Date birthday, string jobTitle, string department)
            : base(firstName, lastName, birthday)
        {
            JobTitle = jobTitle;
            Department = department;
            University = "Житомирський державний університет ім. І. Франка";
        }
        public Lecturer(string firstName, string lastName, Date birthday, string jobTitle)
            : base(firstName, lastName, birthday)
        {
            JobTitle = jobTitle;
            Department = "Кафедра комп'ютерних наук та інформаційних технологій";
            University = "Житомирський державний університет ім. І. Франка";
        }
        public override string ShowInfo()
        {
            return $"Ім'я - {FirstName}, Прізвище - {LastName}, Дата народження - {Birthday.GetInfo()}, Посада - {JobTitle}, Кафедра - {Department}, ВУЗ - {University}\n";
        }
    }
}
