namespace Problem05.OrderStudents
{
    using System;
    using System.Linq;
    using Models;

    class OrderStudents
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;

            var sortedStudentsLambda = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName).ToList();
            var sortedStudentsLINQ = from student in students
                                     orderby student.FirstName descending
                                     orderby student.LastName descending
                                     select student;
            Console.WriteLine("Sorted with lambda:");
            foreach (var student in sortedStudentsLambda)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("Sorted with LINQ:");
            foreach (var student in sortedStudentsLINQ)
            {
                Console.WriteLine(student);
            }
        }
    }
}
