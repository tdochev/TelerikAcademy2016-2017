namespace Animals.Models
{
    using System;
    using System.Linq;
    using Animals.Interfaces;
    using System.Collections;
    using System.Collections.Generic;
    public abstract class Animal : ISound
    {
        public Animal(string name, int age, Sex sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }
        public string Name { get; private set; }

        public int Age { get; private set; }

        public Sex Sex { get; private set; }

        public AnimalKind AnimalKind { get; protected set; }

        public abstract string ProduceSound();

        public static double GetAverageAge(IEnumerable<Animal> animalsCollection)
        {
            return animalsCollection.Average(a => a.Age);
        }

        public override string ToString()
        {
            return string.Format("My name is {0}, i am a {1} years old {2}", this.Name, this.Age, this.Sex);
        }
    }
}
