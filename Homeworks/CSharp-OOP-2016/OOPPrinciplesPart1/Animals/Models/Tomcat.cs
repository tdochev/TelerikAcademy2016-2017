namespace Animals.Models
{
    using Animals.Enums;

    class Tomcat : Cat
    {
         public Tomcat(string name, int age) 
            : base(name, age, Sex.Male)
        {
            this.AnimalKind = AnimalKind.Cat;
        }
        
        public override string ToString()
        {
            return base.ToString() + " " /*+ this.AnimalKind*/ + "Tomcat" + ".";
        }
    }
}
