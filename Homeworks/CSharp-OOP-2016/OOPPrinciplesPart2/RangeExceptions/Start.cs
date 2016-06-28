namespace RangeExceptions
{
    using System;
    using RangeExceptions.Models;

    class Start
    {
        private static void ExceptionThrower<T>(T validRangeStart, T validRangeEnd, T rangeStart, T rangeEnd) where T : IComparable<T>
        {
            try
            {
                if (rangeStart.CompareTo(validRangeStart) < 0 || rangeEnd.CompareTo(validRangeEnd) >  0)
                {
                    throw new InvalidRangeException<T>(validRangeStart, validRangeEnd);
                }
            }
            catch (InvalidRangeException<T> ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
        
        static void Main()
        {
            ExceptionThrower<int>(0, 100, 2, 101);
            ExceptionThrower<DateTime>(new DateTime(1980, 1, 1), new DateTime(2013, 12, 31), new DateTime(2013, 12, 31), new DateTime(2015, 12, 31));
        }
    }
}
