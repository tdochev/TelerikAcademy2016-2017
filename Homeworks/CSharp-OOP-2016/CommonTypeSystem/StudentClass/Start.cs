namespace StudentClass
{
    using System;
    using StudentClass.Models;

   public class Start
    {
        public static void Main()
        {
            var firstStudent = new Student("Ivan", "Ivanov", "Ivanov", 1234,"another adress", "+359888345678", "ivan@ivanov.bg", "Some Course", Specialty.Physics, Faculty.Mathemtics, University.MEI);
            var secondStudent = (Student)firstStudent.Clone();
            var thirdStudent = new Student("Gosho", "Georgiev", "Ivanov", 1233, "some address", "+359888123456", "supergosho@abv.bg", "Some Course", Specialty.Physics, Faculty.Mathemtics, University.MEI);
            Console.WriteLine(firstStudent);
            Console.WriteLine(secondStudent);
            Console.WriteLine(thirdStudent);
            Console.WriteLine("First student == second student: {0}", firstStudent == secondStudent);
            Console.WriteLine("First student == third student: {0}", firstStudent == thirdStudent);
            Console.WriteLine("First student != third student: {0}", firstStudent != thirdStudent);
            Console.WriteLine("First studen GetHashCode(): {0}", firstStudent.GetHashCode());
            Console.WriteLine("Second studen GetHashCode(): {0}", secondStudent.GetHashCode());
            Console.WriteLine("Third studen GetHashCode(): {0}", thirdStudent.GetHashCode());
            Console.WriteLine(firstStudent.CompareTo(thirdStudent));
        }
    }
}
