using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaAlgorithms
{
    internal class E
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
            for (int i = 0; i < a.Length; i++)
            {
                int ind = Binary(a, i + 1, sum - a[i]);
                if (ind > 0)
                {
                    return new int[] { a[i], a[ind] };
                }
            }
            return new int[] { };
        }

        public static int Binary(int[] mas, int start, int number)
        {
            int low = start;
            int high = mas.Length - 1;
            while (low <= high)
            {
                var mid = (low + high) / 2;
                var guess = mas[mid];
                if (guess == number) return mid;
                if (guess > number) high = mid - 1;
                if (guess < number) low = mid + 1;
            }
            return -1;
        }
    }
}
