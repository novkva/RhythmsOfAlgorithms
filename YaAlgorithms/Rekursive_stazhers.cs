using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace YaAlgorithms
{
    internal class Rekursive_stazhers
    {
        private static TextReader reader;

        public Rekursive_stazhers()
        {
            reader = new StreamReader("input.txt");
            //writer = new StreamWriter(Console.OpenStandardOutput());

            var count = ReadInt();
            var commites = CommitCount(count[0], count[1]);
            //Console.WriteLine(CommitCount(327628));
            //Console.WriteLine(CommitCount(170));
            //Console.WriteLine(CommitCount(500));
            //Console.WriteLine(CommitCount(1235));
            //Console.WriteLine(CommitCount(4500));
            Console.WriteLine(commites);
            //var res = Int32.Parse(commites.ToString().Substring(commites.ToString().Length - count[1]));
            //Console.WriteLine(res);
        }

        private static int[] ReadInt()
        {
            return reader.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }

        //private static int CommitCount(int number)
        //{
        //    if (number == 1 || number == 0) return 1;
        //    return CommitCount(number - 1) + CommitCount(number - 2);
        //}
        private static long CommitCount(int number, int ct)
        {
            if (number == 1 || number == 0) return 1;
            long step = 2;
            long prev = 1;
            long count = 2;
            while(step < (long) number)
            {
                count += prev;
                prev = count - prev;
                count %= (long) Math.Pow(10,ct);
                step++;
            }
            return count;
        }
    }
}
