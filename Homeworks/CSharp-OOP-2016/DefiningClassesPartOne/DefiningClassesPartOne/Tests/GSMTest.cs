namespace DefiningClassesPartOne.Tests
{
    using System;

    using DefiningClassesPartOne.Models;

    public class GSMTest
    {
        public static void GSMStartTest()
        {
            Console.WriteLine("GSM Test");
            DrawLine();
            GSM[] testArray = new GSM[4];
            testArray[0] = new GSM("iPhone 5", "Apple", 1987m, "Gosho", new Battery("Foxconn", 800, 400), new Display(5.3m,134000));
            testArray[1] = new GSM("G4", "LG", 987m, "Pesho", new Battery("LG Battery", BatteryType.Li_Ion, 800, 400));
            testArray[2] = new GSM("iPhone 4s", "Apple", 687m, "Ivan", new Battery("Foxconn", 800, 400), new Display(5.3m, 134000));

            foreach (var gsm in testArray)
            {
                Console.WriteLine(gsm);
                //DrawLine();
            }
        }

        private static void DrawLine()
        {
            Console.WriteLine(new string('-', Console.WindowWidth - 1));
        }
    }
}
