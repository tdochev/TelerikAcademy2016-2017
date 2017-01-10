namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using StudentsAndWorkers.Models;

    public class Start
    {
        private static void Main()
        {
            IList<Human> humans = new List<Human>();
            var students = new List<Student>()
            {
            new Student("Ivan", "Ivanov", 2),
            new Student("Petar", "Petrov", 3),
            new Student("Pesho", "Peshov", 4),
            new Student("Gosho", "Goshov", 5),
            new Student("Anita", "Radeva", 6),
            new Student("Haralambi", "Hadjikotzev", 2),
            new Student("Mirolub", "Benatov", 3),
            new Student("Hristo", "Hristov", 4),
            new Student("Vampir", "Vampirski", 5),
            new Student("Mirodrag", "Ali", 6),
            };
            var studentsSortedByGradeAscending = students.OrderBy(s => s.Grade);
            foreach (var student in studentsSortedByGradeAscending)
            {
                //humans.Add(student);
                Console.WriteLine(student);
            }

            Console.WriteLine();
            IList<Worker> workers = new List<Worker>()
            {
                new Worker("Petyo", "Petev", 320, 8),
                new Worker("Misho", "Mishev", 240, 7),
                new Worker("Vasko", "Vasilev", 310, 6),
                new Worker("Plamen", "Plamenov", 215, 7),
                new Worker("Vishko", "Vishkov", 318, 5),
                new Worker("Viktor", "Viktorov", 200, 4),
                new Worker("Simeon", "Simeonov", 120, 6),
                new Worker("Grisha", "Grishev", 200, 4),
                new Worker("Tomcho", "Tomchev", 300, 7),
                new Worker("Yordan", "Yordanov", 280, 8),
            };
            var workersSortedByMoneyPerHourDescending = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WindowWidth += 30;
            foreach (var worker in workersSortedByMoneyPerHourDescending)
            {
                //humans.Add(worker);
                Console.WriteLine(worker);
            }
            Console.WriteLine();

            humans = humans.Concat(students).Concat(workers).ToList();

            var humansSorted = humans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);
            foreach (var human in humansSorted)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }
        }
    }
}
