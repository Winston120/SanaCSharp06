// See https://aka.ms/new-console-template for more information
using Library;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Person person= new Person("Віталій", "Прухницький", new Date(3, 5, 2000));
Person applicant = new Applicant("Яніна", "Стельмашенко", new Date(10, 10, 2001), new ZNO(150, 160, 140, 0), 9, "Озерненський ліцей");


Console.WriteLine(applicant.ShowInfo());