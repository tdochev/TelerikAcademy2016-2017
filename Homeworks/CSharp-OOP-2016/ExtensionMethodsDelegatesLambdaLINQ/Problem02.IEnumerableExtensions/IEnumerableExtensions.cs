namespace Problem02.IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T MySum<T>(this IEnumerable<T> data)
        {
            if (data.Count() == 0) throw new ArgumentException("The collection is empty;");
            dynamic sum = 0;
            foreach (var element in data)
            {
                sum += element;
            }
            return sum;
        }

        public static T MyProduct<T>(this IEnumerable<T> data)
        {
            if (data.Count() == 0) throw new ArgumentException("The collection is empty;");
            dynamic product = 1;
            foreach (var element in data)
            {
                product *= element;
            }
            return product;
        }

        public static T MyMax<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            if (data.Count() == 0) throw new ArgumentException("The collection is empty;");
            return data.Aggregate((c, d) =>
            {
                if (c.CompareTo(d) > 0)
                {
                    return c;
                }
                else
                {
                    return d;
                }
            });
        }

        public static T MyMin<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            if (data.Count() == 0) throw new ArgumentException("The collection is empty;");
            return data.Aggregate((c, d) =>
            {
                if (c.CompareTo(d) < 0)
                {
                    return c;
                }
                else
                {
                    return d;
                }
            });
        }
        public static T MyAverage<T>(this IEnumerable<T> data) where T : IComparable<T>
        {
            if (data.Count() == 0) throw new ArgumentException("The collection is empty;");
            dynamic sum = 0;
            long count = 0;
            {
                foreach (var element in data)
                {
                    sum += element;
                    count++;
                }
            }
            return sum / count;
        }

        public static void Main()
        {
            var test = new List<double>();
            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            Console.WriteLine("Sum: " + test.MySum());
            Console.WriteLine("Product: " + test.MyProduct());
            Console.WriteLine("Min: " + test.MyMin());
            Console.WriteLine("Max: " + test.MyMax());
            Console.WriteLine("Average: " + test.MyAverage());
        }
    }
}
