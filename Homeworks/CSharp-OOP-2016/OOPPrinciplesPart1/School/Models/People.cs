namespace School.Models
{
    using Interfaces;
    using Common;

    public abstract class People : IComment
    {
        private string name;
        private string comment;

        public People(string name)
        {
            this.Name = name;
        }

        public People(string name, string comment) : this(name)
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