namespace Animals.Models
{
    using Animals.Enums;

    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, Sex.Female)
        {
            this.AnimalKind = AnimalKind.Cat;
        }
        public override string ToString()
        {
            return base.ToString() + " " /*+ this.AnimalKind */ + "Kitten" + ".";
        }
    }
}
