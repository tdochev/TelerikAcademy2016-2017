namespace Problem01.StringBuilder.Substring
{
    using System;
    using System.Text;

    public static class SBSubstring
    {

        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            return new StringBuilder(sb.ToString().Substring(index, length));
        }

        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("test a test");
            var result = sb.Substring(5, 6);
            Console.WriteLine(result);
        }
    }
}

