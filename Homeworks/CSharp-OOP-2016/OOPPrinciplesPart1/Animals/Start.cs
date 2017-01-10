namespace Animals
{
    using System;
    using System.Linq;

    using Animals.Enums;
    using Animals.Models;

    class Start
    {
        static void Main()
        {
            Animal[] animals =
            {
                new Dog("Courage", 3, Sex.Male),
                new Dog("Balkan", 4, Sex.Male),
                new Dog("Scooby", 7, Sex.Male),
                new Frog("Jack", 1, Sex.Male),
                new Frog("Lena", 11, Sex.Female),
                new Frog("Anastasia", 5, Sex.Female),
                new Kitten("Jack", 1),
                new Kitten("Lena", 11),
                new Kitten("Anastasia", 5),
                new Tomcat("Mr. Jingles", 13),
                new Tomcat("Topcat", 11),
                new Tomcat("Chubaka", 9),
            };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
            var allAnimalsAverageAge = Animal.GetAverageAge(animals);
            var dogsAverageAge = Animal.GetAverageAge(animals.Where(t => t.AnimalKind == AnimalKind.Dog));
            var frogsAverageAge = Animal.GetAverageAge(animals.Where(t => t is Frog));
            var kittenAverageAge = Animal.GetAverageAge(animals.Where(t => t is Kitten));
            var tomcatAverageAge = Animal.GetAverageAge(animals.Where(t => t is Tomcat));
            Console.WriteLine("The average age of all animals in the array is: {0:f2} years.", allAnimalsAverageAge);
            Console.WriteLine("The Aaerage age per type is:\nDogs - {0:f2} years\nFrogs - {1:f2} years\nKitten - {2:f2} years\nTomcat - {3:f2} years"
                , dogsAverageAge, frogsAverageAge, kittenAverageAge, tomcatAverageAge);
        }
    }
}