namespace Problem18.GroupedByGroupNumber
{
    using System;
    using System.Linq;
    using Models;

    class GroupedByGroupNumber
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var groupedStudents =
            from student in students
            group student by student.GroupNumber into newGroup
            orderby newGroup.Key
            select newGroup;

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
