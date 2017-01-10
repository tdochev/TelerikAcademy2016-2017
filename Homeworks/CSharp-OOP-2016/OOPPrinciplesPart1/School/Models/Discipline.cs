////Disciplines have a name, number of lectures and number of exercises.
namespace School.Models
{
    using Common;
    using Interfaces;

    public class Discipline : IComment
    {
        private string name;
        private string comment;

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

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.ValidateValueLengtRange(value, Constants.MIN_NAME_LENGTH, Constants.MAX_NAME_LENGTH,
                    string.Format(Messages.VALID_LENGTH_RANGE, "Name", Constants.MIN_NAME_LENGTH, Constants.MAX_NAME_LENGTH));

                this.name = value;
            }
        }

        public uint NumberOfLectures { get; set; }

        public uint NumberOfExercises { get; set; }

        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                Validator.ValidateValueLengtRange(value, Constants.MIN_COMMENT_LENGTH, Constants.MAX_COMMENT_LENGTH,
                    string.Format(Messages.VALID_LENGTH_RANGE, "Comment", Constants.MIN_COMMENT_LENGTH, Constants.MAX_COMMENT_LENGTH));

                this.comment = value;
            }
        }
    }
}