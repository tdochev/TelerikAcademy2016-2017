namespace PersonClass
{
    public class Start
    {
        public static void Main()
        {
            var person = new Person("Ivan");
            var anotherperson = new Person("Gosho", 25);
            System.Console.WriteLine(person);
            System.Console.WriteLine(anotherperson);
        }
    }
}
