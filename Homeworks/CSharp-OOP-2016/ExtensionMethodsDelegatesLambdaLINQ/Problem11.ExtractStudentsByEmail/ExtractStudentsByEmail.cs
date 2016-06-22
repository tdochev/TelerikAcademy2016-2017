namespace Problem11.ExtractStudentsByEmail
{
    using System;
    using System.Linq;
    using Models;
    
    class ExtractStudentsByEmail
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var studentsMailInAbv = from student in students
                                    where student.Email.Contains("abv.bg")
                                    select student;
            Console.WriteLine("Students with mail in abv.bg: " + Environment.NewLine + string.Join(Environment.NewLine, studentsMailInAbv));
        }
    }
}