using System;

namespace School.Common
{
    public class Validator
    {
        public static void ValidateValueLengtRange(string value, int minLength, int maxLength,  string errorMessage)
        {
            int valueLength = value.Length;
            if (valueLength < minLength || valueLength > maxLength)
            {
                throw new ArgumentOutOfRangeException(errorMessage);
            }
        }

        public static void ValidateNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }
    }
}
