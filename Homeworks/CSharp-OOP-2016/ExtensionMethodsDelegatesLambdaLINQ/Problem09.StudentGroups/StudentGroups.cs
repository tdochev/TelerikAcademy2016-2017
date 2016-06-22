namespace Problem09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class StudentGroups
    {
        static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var studentsFromGroupTwo = from student in students
                                       where student.GroupNumber == 2
                                       orderby student.FirstName
                                       select student;
                                       
            Console.WriteLine("Student from group two: " + Environment.NewLine + string.Join(Environment.NewLine, studentsFromGroupTwo));
        }
    }
}

