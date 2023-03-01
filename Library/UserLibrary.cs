using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class UserLibrary:Person
    {
        public string LibraryCardNumber { get; set; }
        public Date IssueDate { get; set; }
        public int MonthlyReadingFee { get; set; }
        public UserLibrary(string firstName, string lastName, Date birthday, string libraryCardNumber, Date issueDate, int monthlyReadingFee)
            : base (firstName, lastName, birthday)
        {
            LibraryCardNumber = libraryCardNumber;
            IssueDate = new Date(issueDate);
            MonthlyReadingFee = monthlyReadingFee;
        }
        public UserLibrary(string firstName, string lastName, Date birthday, string libraryCardNumber, Date issueDate)
            : base(firstName, lastName, birthday)
        {
            LibraryCardNumber = libraryCardNumber;
            IssueDate = new Date(issueDate);
            MonthlyReadingFee = 0;
        }
        public UserLibrary(string firstName, string lastName, Date birthday, string libraryCardNumber)
            : base(firstName, lastName, birthday)
        {
            LibraryCardNumber = libraryCardNumber;
            IssueDate = new Date();
            MonthlyReadingFee = 0;
        }

    }
}
