using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaAlgorithms
{
    public class C
    {

        public static void Slicer(int[] a, int slice)
        {
            var baseSlice = a.Take(slice).Sum();
            Console.Write($"{(double)baseSlice / slice} ");
            for (int i = slice; i < a.Length; i++)
            {
                baseSlice += a[i] - a[i-slice];
                
                Console.Write($"{(double)baseSlice / slice} ");
            }
        }

        public static void Mains(string[] args)
        {
            var reader1 = Console.ReadLine();
            var reader2 = ParserToIntArray(Console.ReadLine());
            var slice = Int32.Parse(Console.ReadLine());

            Slicer(reader2, slice);
        }

        public static int[] ParserToIntArray(string mas)
        {
            return mas.Split(' ').Select(int.Parse).ToArray();
        }
    }
}
