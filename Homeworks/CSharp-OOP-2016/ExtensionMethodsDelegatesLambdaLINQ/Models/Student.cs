namespace Models
{
    using System.Collections.Generic;

    public class Student
    {
        private List<int> marks;

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

        public int FN
        {
            get;
            private set;
        }

        public string Tel
        {
            get;
            private set;
        }

        public string Email
        {
            get;
            private set;
        }

        public List<int> Marks
        {
            get { return new List<int>(marks); }
            set { this.marks = value; }
        }

        public int GroupNumber
        {
            get;
            private set;
        }


        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.marks = new List<int>();
        }

        public Student(string firstName, string lastName, uint age)
        : this(firstName, lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public Student(string firstName, string lastName, uint age, int fn)
        : this(firstName, lastName, age)
        {
            this.FN = fn;
        }

        public Student(string firstName, string lastName, uint age, int fn, string tel)
        : this(firstName, lastName, age, fn)
        {
            this.Tel = tel;
        }

        public Student(string firstName, string lastName, uint age, int fn, string tel, string email)
        : this(firstName, lastName, age, fn, tel)
        {
            this.Email = email;
        }

        public Student(string firstName, string lastName, uint age, int fn, string tel, string email, List<int> marks)
        : this(firstName, lastName, age, fn, tel, email)
        {
            this.Marks = marks;
        }

        public Student(string firstName, string lastName, uint age, int fn, string tel, string email, List<int> marks, int groupNumber)
        : this(firstName, lastName, age, fn, tel, email, marks)
        {
            this.GroupNumber = groupNumber;
        }

        public Student(string firstName, string lastName, int groupNumber)
        : this(firstName, lastName)
        {
            this.GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            return string.Format("Student: FirstName={0}, LastName={1}, Age={2}, FN={3}, Tel={4}, Email={5}, Marks={6}, GroupNumber={7}", FirstName, LastName, Age, FN, Tel, Email, string.Join(", ", Marks), GroupNumber);
        }
        
        public class TestList
        {
            public static List<Student> MyStudentsList = new List<Student>
            {
                new Student ("Ivan", "Ivanov", 28, 234506,"+35928701543","ivan@dir.bg", new List<int>{2,2},3),
                new Student ("Gosho", "Goshev", 18, 345508,"+359886234567","gosho@gmail.com", new List<int>{2,4,2},2),
                new Student ("Peshov", "Peshov", 19, 237906,"+359888123456","pesho@abv.bg", new List<int>{2,5,6},3),
                new Student ("Stefcho", "Petrov", 42, 234211,"028659907","stefcho@yahoo.com", new List<int>{2,3,5},1),
                new Student ("Ivan", "Aprilov", 22, 234512,"+359888123456","ivan@abv.bg", new List<int>{5,6,6},2)
            };
        }
    }
}