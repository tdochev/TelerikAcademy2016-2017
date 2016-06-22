namespace Problem12.ExtractStudentsByPhone
{
    using System;
    using System.Linq;
    using Models;

    class ExtractStudentsByPhone
    {
        public static void Main()
        {
            var students = Student.TestList.MyStudentsList;
            var studnetsWithPhoneInSofia = from student in students
                                           where student.Tel.Substring(0, 5) == "+3592" ||
                                           student.Tel.Substring(0, 6) == "003592" ||
                                           student.Tel.Substring(0, 2) == "02"
                                           select student;
            Console.WriteLine("Students with mail in abv.bg: " + Environment.NewLine + string.Join(Environment.NewLine, studnetsWithPhoneInSofia));
        }
    }
}
