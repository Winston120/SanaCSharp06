using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Applicant : Person
    {
        protected ZNO AverageValueСertificate;
        protected int PointsEducationalDoc { get; set; }
        protected string NameSchool { get; set; }

        public Applicant(string firstName, string lastName, Date birthday, ZNO averageValueСertificate,  int pointsEducationalDoc, string nameSchool)
            : base(firstName, lastName, birthday)
        {
            AverageValueСertificate = new ZNO(averageValueСertificate);
            PointsEducationalDoc = pointsEducationalDoc;
            NameSchool = nameSchool;
        }
        public Applicant(string firstName, string lastName, Date birthday, ZNO averageValueСertificate, int pointsEducationalDoc)
            : base(firstName, lastName, birthday)
        {
            AverageValueСertificate = new ZNO(averageValueСertificate);
            PointsEducationalDoc = pointsEducationalDoc;
            NameSchool = "Житомирський ліцей №25";
        }
        public Applicant(string firstName, string lastName, Date birthday, ZNO averageValueСertificate, string nameSchool)
            : base(firstName, lastName, birthday)
        {
            AverageValueСertificate = new ZNO(averageValueСertificate);
            PointsEducationalDoc = 0;
            NameSchool = "Житомирський ліцей №25";
        }

        public override string ShowInfo()
        {
            return $"Ім'я - {FirstName}, Прізвище - {LastName}, Дата народження - {Birthday.GetInfo()}, Назва школи - {NameSchool}, Бал атестату - {PointsEducationalDoc}, {AverageValueСertificate.GetInfo()}";
        }
    }
}
