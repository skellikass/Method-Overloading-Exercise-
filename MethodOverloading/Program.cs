using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        public static void Add (int int1, int int2)
        {
            Console.WriteLine(int1 + int2);
        }
        public static void Add(decimal dec1, decimal dec2)
        {
            Console.WriteLine(dec1 + dec2);
        }
        public static string Add(int int1, int int2, bool bool1)
        {
            if (bool1 == true && int1 + int2 > 1 || int1 + int2 < 1)
            {
                return $"{int1 + int2} dollars";
            }
            else if (bool1 == true && int1 + int2 == 1)
            {
                return $"{int1 + int2} dollar";
            }
            else
            {
                return $"{int1 + int2}";
            }
        }
        static void Main()
        {
            Add(12, 3);
            Add(1.23m, 4.56m);
            Console.WriteLine(Add(1, 23, false));
        }
    }
}
