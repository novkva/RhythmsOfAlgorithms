using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaAlgorithms
{
    internal class D
    {
        public static void Mains(string[] args)
        {
            var reader1 = Console.ReadLine();
            var reader2 = ParserToIntArray(Console.ReadLine());
            var sum = Int32.Parse(Console.ReadLine());

            var res = Finder(reader2, sum);
            if (res.Length > 0) Console.WriteLine($"{res[0]} {res[1]}");
            else Console.WriteLine("None");
        }

        public static int[] ParserToIntArray(string mas)
        {
            return mas.Split(' ').Select(int.Parse).ToArray();
        }

        public static int[] Finder(int[] a, int sum)
        {
            for(int i = 0; i < a.Length; i++)
            {
                for(int k = i+1; k< a.Length; k++)
                {
                    if (a[i] + a[k] == sum)
                    {
                        return new int[] {a[i], a[k]};
                    }
                }
            }
            return new int[] { };
        }

        int AssWrapperWithStatic(int x, int y)
        {
            return Add(x, y);
            static int Add(int x, int y) => x + y;
        }

        void Add(ref int x) { }
        void Add(int x) { }
    }
     
    enum Type : byte
    {
        Spoon = 1,
        Fork = 4,
        Chinese = 2
    }
}
