namespace Library
{
    public class Person
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public Date Birthday { get; set; }

        public Person(string firstName, string lastName, Date birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = new Date(birthday);
        }
        public Person(string firstName)
        {
            FirstName = firstName;
            LastName = "---";
            Birthday = new Date(2003, 1, 1);
        }
        public Person()
        {
            FirstName = "Іван";
            LastName = "Іванов";
            Birthday = new Date(2000, 5, 1);
        }
        public virtual string ShowInfo()
        {
            return $"Ім'я - {FirstName}, Прізвище - {LastName}, Дата народження - {Birthday.GetInfo()}";
        }

    }
}