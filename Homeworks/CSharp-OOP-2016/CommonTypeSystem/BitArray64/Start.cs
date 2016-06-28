namespace BitArray64
{
    using System;

    public class Start
    {
        public static void Main()
        {
            var firstTest = new BitArray64(ulong.MinValue);
            var secondTest = new BitArray64(ulong.MaxValue);
            var thirdTest = new BitArray64(ulong.MaxValue);
            var forthTest = new BitArray64(100u);
            Console.WriteLine("First 64 Bit array (ulong min value): " +  firstTest);
            Console.WriteLine("Second 64 Bit array (ulong max value): " + secondTest);
            Console.WriteLine("Third 64 Bit array (ulong max value): " + thirdTest);
            Console.WriteLine("Third 64 Bit array (100): " + forthTest);
            Console.WriteLine("first == second: " + (firstTest == secondTest));
            Console.WriteLine("first != second: " + (firstTest != secondTest));
            Console.WriteLine("second != third: " + (secondTest == thirdTest));
            Console.WriteLine(forthTest.Number);
            Console.WriteLine(forthTest.GetHashCode());
        }
    }
}