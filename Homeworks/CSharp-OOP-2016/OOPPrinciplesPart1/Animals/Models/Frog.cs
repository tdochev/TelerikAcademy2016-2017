namespace Animals.Models
{
    using Animals.Enums;

    class Frog : Animal
    {
        public Frog(string name, int age, Sex sex)
            : base(name, age, sex)
        {
            this.AnimalKind = AnimalKind.Frog;
        }

        public override string ProduceSound()
        {
            return "Ribbit, ribbit!";
        }
        
        public override string ToString()
        {
            return ProduceSound() + " " + base.ToString() + " " + this.AnimalKind + ".";
        }
    }
}