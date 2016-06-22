namespace Problem04.AgeRange
{
    public class Student
    {
        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }

        public uint Age
        {
            get;
            private set;
        }

        public Student(string firstName, string lastName, uint age)
        : this(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
