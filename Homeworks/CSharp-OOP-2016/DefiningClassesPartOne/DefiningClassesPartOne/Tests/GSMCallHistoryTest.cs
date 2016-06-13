namespace DefiningClassesPartOne.Tests
{
    using System;
    using System.Linq;
    using DefiningClassesPartOne.Models;

    public static class GSMCallHistoryTest
    {
        public static void GSMCallHistoryStartTest()
        {
            Console.WriteLine("Call history test");
            DrawLine('-');
            var testGsm = new GSM("iPhone 18s", "Apple", 1800m, "Batman");
            Random rndCallLengthGen = new Random();
            Random rndNumberGen = new Random();
            for (int i = 0; i < 10; i++)
            {
                string number = "+359" + rndNumberGen.Next(82000001, 90000000);
                uint callDuration = (uint)rndCallLengthGen.Next(8, 361);
                var call = new Call(callDuration, number);
                testGsm.AddCall(call);
            }
            
            PrintCallHistory(testGsm);
            Console.WriteLine("Total calls price: {0:f2}", testGsm.GetCallsPrice(0.37m));
            Call logestCall = testGsm.CallHistory.OrderByDescending(c => c.Duration).FirstOrDefault();
            testGsm.DeleteCall(logestCall);
            Console.WriteLine("Total calls price after deleting the longest call: {0:f2}", testGsm.GetCallsPrice(0.37m));
            testGsm.ClearCallHistory();
            PrintCallHistory(testGsm);
        }

        private static void PrintCallHistory(GSM gsm)
        {
            foreach (var call in gsm.CallHistory)
            {
                Console.WriteLine(call);
                DrawLine('*');
            }
            
            if (gsm.CallHistory.Count == 0)
            {
                Console.WriteLine("The call history is empty!");
            }
        }

        private static void DrawLine(char ch)
        {
            Console.WriteLine(new string(ch, Console.WindowWidth - 1));
        }
    }
}
