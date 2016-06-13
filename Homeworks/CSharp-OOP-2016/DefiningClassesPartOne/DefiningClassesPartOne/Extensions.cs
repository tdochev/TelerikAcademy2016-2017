namespace DefiningClassesPartOne
{
    using System.Collections.Generic;
    using DefiningClassesPartOne.Models;

    public static class Extensions
    {
        public static string ExtendedToString(this List<Call> list)
        {
            return string.Join(", ",list);
        }
    }
}

