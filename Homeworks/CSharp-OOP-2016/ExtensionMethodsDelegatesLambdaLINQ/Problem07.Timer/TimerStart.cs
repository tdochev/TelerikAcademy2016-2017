namespace Problem07.Timer
{
    using System;

    class TimerStart
    {
        public static void Main(string[] args)
        {
            TimerDelegate timerDelegate = new TimerDelegate(5, test);

        }

        static void test()
        {
            Console.WriteLine("The Method was excexuted at " + DateTime.Now);
        }
    }
}
