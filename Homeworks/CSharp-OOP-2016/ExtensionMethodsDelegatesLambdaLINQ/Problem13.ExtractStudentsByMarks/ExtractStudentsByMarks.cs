namespace Problem13.ExtractStudentsByMarks
{
    using System;
    using System.Linq;

    using Models;

    class ExtractStudentsByMarks
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var studentWithOneMarlExcellent = from student in students
                                              where student.Marks.Contains(6)
                                              select new
                                              {
                                                  FullName = student.FirstName + " " + student.LastName,
                                                  Marks = string.Join(", ", student.Marks)
                                              };
            Console.WriteLine("All students that have at least one mark Excellent (6):");
            foreach (var student in studentWithOneMarlExcellent)
            {
                Console.WriteLine(student);
            }
        }
    }
}
