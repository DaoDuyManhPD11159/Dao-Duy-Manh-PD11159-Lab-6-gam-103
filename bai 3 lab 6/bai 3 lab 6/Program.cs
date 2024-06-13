using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_3_lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> list2 = new List<int>() { 5, 6, 7, 8, 1 };

            Console.WriteLine("Union (giam dan):");
            var unionDescending = list1.Union(list2).OrderByDescending(x => x);
            foreach (var item in unionDescending)
            {
                Console.WriteLine(item + " ");
            }

            Console.WriteLine("\n\nIntersect:");
            var intersect = list1.Intersect(list2);
            foreach (var item in intersect)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\nConcat (tang dan):");
            var concatAscending = list1.Concat(list2).OrderBy(x => x);
            foreach (var item in concatAscending)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("n\nExcept:");
            var except = list1.Except(list2);
            foreach (var item in except)
            {
                Console.Write(item + " ");
            }
        }
    }
}
