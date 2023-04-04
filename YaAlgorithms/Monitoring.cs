using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaAlgorithms
{
    public class Monitoring
    {
        private static TextReader reader;
        private static TextWriter writer;
        public Monitoring()
        {
            reader = new StreamReader("input.txt");
            writer = new StreamWriter(Console.OpenStandardOutput());

            var line = ReadInt();
            var column = ReadInt();

            var matrix = ReadList();

            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j< line; j++)
                {
                    Console.Write($"{matrix[j * column+i]} ");
                }
                Console.WriteLine();
            }

            reader.Close();
            writer.Close();
            }
        

        private static int ReadInt()
        {
            return int.Parse(reader.ReadLine());
        }

        private static List<int> ReadList()
        {
            var list = reader.ReadToEnd()
                .Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            return list;
        }
    }
}
