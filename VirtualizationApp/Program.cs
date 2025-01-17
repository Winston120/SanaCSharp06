﻿// See https://aka.ms/new-console-template for more information
using Library;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Person person= new Person("Віталій", "Прухницький", new Date(3, 5, 2000));
Person applicant = new Applicant("Яніна", "Стельмашенко", new Date(10, 10, 2001), new ZNO(150, 160, 140, 0), 9, "Озерненський ліцей");
Person student = new Student("Яніна", "Стельмашенко", new Date(10, 10, 2001), 1, "15Мд-СОІнф", "Фізико-математичний", "Житомирський державний університет ім. І. Франка");
Person lecturer = new Lecturer("Сергій", "Жуковський", new Date(10, 10, 1985), "Доцент, кандидат педагогічних наук", "Кафедра комп'ютерних наук та інформаційних технологій", "Житомирський державний університет ім. І. Франка");
Person userLibrary = new UserLibrary("Яніна", "Стельмашенко", new Date(10, 10, 2001), 24, new Date(1, 3, 2023), 200);


List<Person> persons = new List<Person>();
persons.Add(person);
persons.Add(applicant);
persons.Add(student);
persons.Add(lecturer);
persons.Add(userLibrary);

foreach(Person personsItem in persons)
{
    Console.WriteLine(personsItem.ShowInfo());
}
