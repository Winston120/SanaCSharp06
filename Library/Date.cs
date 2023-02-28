using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Date
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date()/*По замовчуванню*/
        {
            Year = 2023;
            Month = 2;
            Day = 3;
        }
        public Date(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
        public Date(Date date)/*Копіювання*/
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
        }
    }

}
