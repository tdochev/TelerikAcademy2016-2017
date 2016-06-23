////Disciplines have a name, number of lectures and number of exercises.
namespace School.Models
{
    using Interfaces;

    public class Discipline : IComment
    {
        public Discipline(string name, uint numberOfLectures, uint numberOfExcersises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExcersises;
        }

        public Discipline(string name, uint numberOfLectures, uint numberOfExcersises, string comment)
            : this(name, numberOfLectures, numberOfExcersises)
        {
            this.Comment = comment;
        }

        public string Name { get; set; }

        public uint NumberOfLectures { get; set; }

        public uint NumberOfExercises { get; set; }

        public string Comment { get; set; }
    }
}