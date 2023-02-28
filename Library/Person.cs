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
    }
}