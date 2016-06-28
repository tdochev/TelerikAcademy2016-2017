namespace RangeExceptions.Models
{
    using System;

    public class InvalidRangeException<T> : SystemException
    {
        public InvalidRangeException(T start, T end, string message) : base (message)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public override string Message
        {
            get
            {
                return $"Invalid Range! The valid rage is [{this.Start}; {this.End}]";
            }
        }

        public T Start { get; private set; }

        public T End { get; private set; }
    }
}
