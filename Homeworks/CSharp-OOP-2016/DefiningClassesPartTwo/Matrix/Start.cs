namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Start
    {
        public static void Main()
        {
            Type type = typeof(Matrix<int>);
            var allAttributes = type.GetCustomAttributes(false);
            for (int i = 1; i < allAttributes.Length; i++)
            {
                Console.WriteLine("Matrix class version {0}.", allAttributes[i]);
            }

            Console.WriteLine();
            var testMatrix = new Matrix<int>(2, 2);
            testMatrix[0, 0] = 1;
            testMatrix[0, 1] = 2;
            testMatrix[1, 0] = 3;
            testMatrix[1, 1] = 4;
            var anothertestMatrix = new Matrix<int>(2, 2);
            anothertestMatrix[0, 0] = 5;
            anothertestMatrix[0, 1] = 6;
            anothertestMatrix[1, 0] = 7;
            anothertestMatrix[1, 1] = 8;
            Console.WriteLine("First matrix:");
            Console.WriteLine(testMatrix);
            Console.WriteLine("Second matrix");
            Console.WriteLine(anothertestMatrix);
            Console.WriteLine("First matrix + second matrix:");
            Console.WriteLine(testMatrix + anothertestMatrix);
            Console.WriteLine("First matrix - second matrix:");
            Console.WriteLine(anothertestMatrix - testMatrix);
            Console.WriteLine("First matrix * second matrix:");
            Console.WriteLine(testMatrix * anothertestMatrix);
        }
    }
}
