using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_1_lab_6
{
    class Program
    {
        static void Main()
        {
            List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };
            List<string> listStr = new List<string>() { null, "T1", "T2", "T3", null };
            List<string> listNull = new List<string>();

            int firstEvenGreaterThan5 = listInt.FirstOrDefault(x => x > 5 && x % 2 == 0);
            Console.WriteLine("First even number greater than 5: " + firstEvenGreaterThan5);

            int lastGreaterThan200 = listInt.LastOrDefault(x => x > 200);
            Console.WriteLine("Last element greater than 200: " + lastGreaterThan200);

            string firstStartsWithT = listStr.FirstOrDefault(x => x != null && x.StartsWith("T"));
            Console.WriteLine("First element starting with 'T': " + firstStartsWithT);

            int sumOfOddIndexValuesDivisibleBy2 = listInt
                .Where((x, index) => index % 2 != 0 && x % 2 == 0)
                .Sum();
            Console.WriteLine("Sum of values at odd indices and divisible by 2: " + sumOfOddIndexValuesDivisibleBy2);
        }
    }
}
