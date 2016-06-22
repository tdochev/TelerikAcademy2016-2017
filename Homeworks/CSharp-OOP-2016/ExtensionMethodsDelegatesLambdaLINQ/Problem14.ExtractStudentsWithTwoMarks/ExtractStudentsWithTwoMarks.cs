namespace Problem14.ExtractStudentsWithTwoMarks
{
    using System;
    using System.Linq;

    using Models;

    class ExtractStudentsWithTwoMarks
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var studentsWithTwoMarks = students.Where(x => x.Marks.All(y => y == 2) && x.Marks.Count==2);
            Console.WriteLine(string.Join(", ", studentsWithTwoMarks));
        }
    }
}
