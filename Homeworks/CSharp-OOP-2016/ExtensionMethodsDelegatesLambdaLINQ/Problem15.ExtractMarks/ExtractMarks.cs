namespace Problem15.ExtractMarks
{
    using System;
    using System.Linq;
    
    using Models;
    
    class ExtractMarks
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var studentsEnrolled2006 = students.Where(s => s.FN.ToString().Substring(4, 2) == "06");
            
            Console.WriteLine("Students that enrolled in 2006:");
            Console.WriteLine(string.Join(Environment.NewLine, studentsEnrolled2006));
        }
    }
}
