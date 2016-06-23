namespace School.Models
{
    public class Student : People 
    {
        public Student(string name, uint classNumber) : base(name)
        {
            this.ClassNumber = classNumber;
        }
        
        public Student(string name, uint classNumber, string comment) : base(name, comment)
        {
            this.ClassNumber = classNumber;
        }

        public uint ClassNumber { get; private set; }
    }
}
