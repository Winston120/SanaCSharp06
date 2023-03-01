using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public Date()/*По замовчуванню*/
        {
            Day = 1;
            Month = 3;
            Year = 2023;
        }
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public Date(Date date)/*Копіювання*/
        {
            Day = date.Day;
            Month = date.Month;
            Year = date.Year;
        }
        public string GetInfo()
        {
            return $"{Day}.{Month}.{Year}";
        }
    }

}
