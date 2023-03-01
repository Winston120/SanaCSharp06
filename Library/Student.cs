using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Student : Person
    {
        public int Course { get; set; }
        public string Groupe { get; set; }
        public string Faculty { get; set; }
        public string University { get; set; }

        public Student(string firstName, string lastName, Date birthday, int course, string groupe, string faculty, string university)
            :base(firstName, lastName, birthday)
        { 
            Course = course;
            Groupe = groupe;
            Faculty = faculty;
            University = university;
        }
        public Student(string firstName, string lastName, Date birthday, int course, string groupe, string faculty)
            : base(firstName, lastName, birthday)
        {
            Course = course;
            Groupe = groupe;
            Faculty = faculty;
            University = "Житомирський державний університет ім. І. Франка";
        }
        public Student(string firstName, string lastName, Date birthday, string groupe, string faculty, string university)
            : base(firstName, lastName, birthday)
        {
            Course = 1;
            Groupe = groupe;
            Faculty = faculty;
            University = university;
        }
        public override string ShowInfo()
        {
            return $"Ім'я - {FirstName}, Прізвище - {LastName}, Дата народження - {Birthday.GetInfo()}, Курс - {Course} , Група - {Groupe}, Факультет - {Faculty}, ВУЗ - {University}\n";
        }
    }
}
