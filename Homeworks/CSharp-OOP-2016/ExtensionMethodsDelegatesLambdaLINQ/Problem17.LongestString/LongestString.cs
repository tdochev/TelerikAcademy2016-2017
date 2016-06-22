namespace Problem17.LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        public static void Main()
        {
            var strings = new string[] { "aaa", "bbbb", "ccccc" };
            var sortedByLenght = from str in strings
                                 orderby str.Length descending
                                 select str;
            string longestString = sortedByLenght.First();
            Console.WriteLine(longestString);
        }
    }
}