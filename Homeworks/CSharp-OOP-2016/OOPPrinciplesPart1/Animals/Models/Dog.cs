namespace Animals.Models
{
    using Animals.Enums;

    class Dog : Animal
    {
        public Dog(string name, int age, Sex sex) 
            : base(name, age, sex)
        {
            this.AnimalKind = AnimalKind.Dog;
        }

        public override string ProduceSound()
        {
            return "Woof, woof!";
        }

        public override string ToString()
        {
            return ProduceSound() + " " +  base.ToString() + " " + this.AnimalKind + ".";
        }
    }
}
