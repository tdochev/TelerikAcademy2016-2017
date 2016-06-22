namespace Problem03.FirstBeforeLast
{
    using System;
    using System.Linq;
    using Models;

    class FirstBeforeLast
    {
        public static void Main()
        {
            var students = new Student[] {
            new Student ("Gosho", "Ivanov"),
            new Student ("Todor", "Ivanov"),
            new Student ("Asparuh", "Georgiev"),
            new Student ("Ivan", "Goshov"),
            new Student ("Abe", "Ivanov"),
            new Student ("Gosho", "Ivanov")
            };

            var studentFirstBeforeLast = FirstNameBeforeLastName(students);
            
            foreach (var student in studentFirstBeforeLast)
            {
            Console.WriteLine(student);
            }
        }

        public static Student[] FirstNameBeforeLastName(Student[] students)
        {
            var result = from student in students
                         where (String.Compare(student.FirstName, student.LastName) < 0)
                         select student;

            return result.ToArray();
        }

    }
}
