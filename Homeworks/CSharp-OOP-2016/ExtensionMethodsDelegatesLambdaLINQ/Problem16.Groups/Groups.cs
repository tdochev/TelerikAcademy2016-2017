namespace Problem16.Groups
{
    using System;
    using System.Linq;

    using Models;

    class GroupsClass
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var groups = Group.TestList.MyGroupsList;

            var mathStudents = from mathGroup in groups
                               where mathGroup.DepartmentName == "Mathematics"
                               join student in students on mathGroup.GroupNumber equals student.GroupNumber
                               select new
                               {
                                   FullName = student.FirstName + " " + student.LastName,
                                   Fn = student.FN,
                                   Department = mathGroup.DepartmentName
                               };
            Console.WriteLine("Students from \"Mathematics\" department:");
            Console.WriteLine(string.Join(Environment.NewLine, mathStudents));
        }
    }
}