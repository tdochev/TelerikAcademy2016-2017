namespace Problem10.StudentGroupsExtensions
{
    using System;
    using System.Linq;
    using Models;

    class StudentGroupsExtensions
    {
        public static void Main(string[] args)
        {
            var students = Student.TestList.MyStudentsList;
            var studentsFromGroupTwo = students.Where(s => s.GroupNumber == 2).OrderBy(s => s.FirstName);
            Console.WriteLine("Student from group two (with lambda): " + Environment.NewLine + string.Join(Environment.NewLine, studentsFromGroupTwo));
        }
    }
}
