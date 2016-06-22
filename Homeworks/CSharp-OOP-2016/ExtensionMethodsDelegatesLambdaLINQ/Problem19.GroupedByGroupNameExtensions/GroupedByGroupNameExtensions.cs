namespace Problem19.GroupedByGroupNameExtensions
{
    using System;
    using System.Linq;

    using Models;
    
    class GroupedByNameExtensions
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var groupedStudents = students.GroupBy(s => s.GroupNumber);

            foreach (var nameGroup in groupedStudents)
            {
                Console.WriteLine($"Group: {nameGroup.Key}");
                foreach (var student in nameGroup)
                {
                    Console.WriteLine($"\t{student.FirstName} {student.LastName}");
                }
            }
        }
    }
}
