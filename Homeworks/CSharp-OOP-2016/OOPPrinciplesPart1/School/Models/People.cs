namespace School.Models
{
    using Interfaces;

    public abstract class People : IComment
    {
        public People(string name)
        {
            this.Name = name;
        }

        public People(string name, string comment) : this(name)
        {
            this.Comment = comment;
        }

        public string Name { get; private set; }

        public string Comment { get; set; }
    }
}