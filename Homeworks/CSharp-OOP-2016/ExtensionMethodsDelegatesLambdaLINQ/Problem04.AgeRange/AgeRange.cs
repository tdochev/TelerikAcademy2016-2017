namespace Problem04.AgeRange
{
    using System;
    using System.Linq;
    using Models;

    class AgeRange
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;

            var youngStudents = from student in students
                                where student.Age >= 18 && student.Age <= 24
                                select new Student(student.FirstName, student.LastName);

            foreach (var student in youngStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
        }
    }
}