using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UserLibrary:Person
    {
        public int LibraryCardNumber { get; set; }
        public Date IssueDate { get; set; }
        public int MonthlyReadingFee { get; set; }
        public UserLibrary(string firstName, string lastName, Date birthday, int libraryCardNumber, Date issueDate, int monthlyReadingFee)
            : base (firstName, lastName, birthday)
        {
            LibraryCardNumber = libraryCardNumber;
            IssueDate = new Date(issueDate);
            MonthlyReadingFee = monthlyReadingFee;
        }
        public UserLibrary(string firstName, string lastName, Date birthday, int libraryCardNumber, Date issueDate)
            : base(firstName, lastName, birthday)
        {
            LibraryCardNumber = libraryCardNumber;
            IssueDate = new Date(issueDate);
            MonthlyReadingFee = 0;
        }
        public UserLibrary(string firstName, string lastName, Date birthday, int libraryCardNumber)
            : base(firstName, lastName, birthday)
        {
            LibraryCardNumber = libraryCardNumber;
            IssueDate = new Date();
            MonthlyReadingFee = 0;
        }
        public override string ShowInfo()
        {
            return $"Ім'я - {FirstName}, Прізвище - {LastName}, Дата народження - {Birthday.GetInfo()}, Номер читацького квитка - {LibraryCardNumber}, Дата видачі - {IssueDate.GetInfo()}, Розмір щомісячного читацького внеска - {MonthlyReadingFee} грн.";
        }

    }
}
