namespace Problem06.DivisibleBy7And3
{
    using System;
    using System.Linq;

    class DivisibleBy7And3
    {
        public static void Main()
        {
            var numbers = new int[] { 1, 3, 7, 21, 37, 42, 55, 63, 99 };
            var divisibleBy7And3Lambda = numbers.Where(x => x % 3 == 0 && x % 7 == 0);
            var divisibleBy7And3LINQ = from number in numbers
                                       where number % 7 == 0 && number % 3 == 0
                                       select number;
            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Numbers divisible by 3 and 7 with lambda: " + string.Join(", ", divisibleBy7And3Lambda));
            Console.WriteLine("Numbers divisible by 3 and 7 with LINQ: " + string.Join(", ", divisibleBy7And3LINQ));
        }
    }
}
