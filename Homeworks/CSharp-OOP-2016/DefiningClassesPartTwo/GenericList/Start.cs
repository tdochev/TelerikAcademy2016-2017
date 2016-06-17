namespace GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Start
    {
        public static void Main()
        {
            var cSharpGenericList = new List<int>();
            var myGenericList = new GenericList<int>();
            for (int i = 0; i < 10; i++)
            {
                cSharpGenericList.Add(i + 1);
                myGenericList.Add(i + 1);
            }

            PrintLists<int>(cSharpGenericList, myGenericList);
            Console.WriteLine("Remove element at index [6]");
            myGenericList.RemoveAt(6);
            cSharpGenericList.RemoveAt(6);
            PrintLists<int>(cSharpGenericList, myGenericList);
            Console.WriteLine("Insert 7 at index [6]");
            myGenericList.Insert(6, 7);
            cSharpGenericList.Insert(6, 7);
            PrintLists<int>(cSharpGenericList, myGenericList);
            Console.WriteLine("Inser 10 more items in the list");
            var currentMax = myGenericList[myGenericList.Count - 1];
            for (int i = 0; i < 10; i++)
            {
                cSharpGenericList.Add(i + currentMax + 1);
                myGenericList.Add(i + currentMax + 1);
            }

            PrintLists<int>(cSharpGenericList, myGenericList);
            Console.WriteLine("Remove element at index [5]");
            myGenericList.RemoveAt(5);
            cSharpGenericList.RemoveAt(5);
            PrintLists<int>(cSharpGenericList, myGenericList);
            Console.WriteLine("Insert 6 at index [5]");
            myGenericList.Insert(5, 6);
            cSharpGenericList.Insert(5, 6);
            PrintLists<int>(cSharpGenericList, myGenericList);
            Console.WriteLine("My generic list Min(): " + myGenericList.Min());
            Console.WriteLine("C# generic list Min(): " + cSharpGenericList.Min());
            Console.WriteLine("My generic list Max(): " + myGenericList.Max());
            Console.WriteLine("C# generic list Max(): " + cSharpGenericList.Max());
        }

        private static void PrintLists<T>(List<T> cSharpList, GenericList<T> myList) where T : IComparable<T>
        {
            Console.WriteLine(new string('*', Console.WindowWidth - 1));
            Console.WriteLine("My generic list: " + myList);
            Console.WriteLine($"Capacity: {myList.Capacity}");
            Console.WriteLine($"Count: {myList.Count}");
            Console.WriteLine(new string('-', Console.WindowWidth - 1));
            Console.WriteLine("C# generic list: " + string.Join(", ", cSharpList));
            Console.WriteLine($"Capacity: {cSharpList.Capacity}");
            Console.WriteLine($"Count: {cSharpList.Count}");
            Console.WriteLine();
        }
    }
}
