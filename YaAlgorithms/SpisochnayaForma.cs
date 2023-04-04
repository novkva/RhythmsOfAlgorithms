using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaAlgorithms
{
    public class SpisochnayaForma
    {
        private static TextReader reader;
        private static int size;
        private static Stack<int> number1;
        private static Stack<int> number2;
        private static Stack<int> result;
        public static void Do(string doc)
        {
            reader = new StreamReader(doc);
            size = ReadInt();
            number1 = ReadArray();
            number2 = ReadIntArray();
            Count();
        }

        //public static void Count()
        //{
        //    //var res = new List<int>();
        //    //int razr = 0;
        //    //for (int i = 0; i< size; i++)
        //    //{
        //    //    var one = number1[size - i - 1];
        //    //    var two = number2 % 10;
        //    //    number2 /= 10;
        //    //    res.Add((one + two) % 10 + razr);
        //    //    if ((one+two) > 9) razr = 1;
        //    //    else razr = 0;  
        //    //}
        //    //if (razr ==1) res.Add(razr);
        //    var one = 0;
        //    var k = Int32.Parse(string.Join(null, number1));
        //    var res = (k + number2).ToString();
        //    Display(res);
        //}

        //public static void Count()
        //{
        //    result = new Stack<int>();
        //    var ind1 = number1.Length - 1;
        //    var ind2 = number2.Length - 1;
        //    var maxMas = number1.Length > number2.Length? number1 : number2;
        //    int razr = 0;
        //    var indMin = ind1 > ind2? ind2:ind1;
        //    var indMax = ind1 < ind2? ind2:ind1;
        //    for (int i = 0; i <= indMin; i++)
        //    {
        //        var cur = number1[ind1-i] + number2[ind2-i];
        //        if (cur > 9)
        //        {
        //            result.Push(cur % 10 + razr);
        //            razr = 1;
        //        }
        //        else
        //        {
        //            result.Push((cur + razr) % 10);
        //            if ((cur + razr) > 9)
        //            {
        //                razr = 1;
        //            }
        //            else razr = 0;
        //        }
        //    }
        //    for (int i = indMax-indMin; i >= 0; i--)
        //    {
        //        if (razr == 1)
        //        {
        //            if ( maxMas[i]+1 > 9)
        //            {
        //               result.Push(0);
        //                razr = 1;
        //            }
        //            else
        //            {
        //                result.Push(maxMas[i]);
        //                razr = 0;
        //            }
        //        }
        //    }
        //    Display();
        //}

        public static void Count()
        {
            result = new Stack<int>();
            int razr = 0;
            while (number1.Count > 0 && number2.Count > 0)
            {
                var cur = number1.Pop() + number2.Pop();
                if (cur > 9)
                {
                    result.Push(cur % 10 + razr);
                    razr = 1;
                }
                else
                {
                    result.Push((cur + razr) % 10);
                    if ((cur + razr) > 9)
                    {
                        razr = 1;
                    }
                    else razr = 0;
                }
            }
            var ost = number1.Count > 0 ? number1 : number2;
            while (ost.Count > 0)
            {
                if (razr == 0) result.Push(ost.Pop());
                else
                {
                    var cur = ost.Pop();
                    if (cur == 9)
                    {
                        result.Push(0);
                        razr = 1;
                    }
                    else
                    {
                        result.Push(cur + 1);
                        razr = 0;
                    }
                }
            }
            if (razr == 1) result.Push(1);
            Display();
        }
        public static void Display()
        {
            int c = result.Count;
            for (int i = 0; i < c; i++)
            {
                Console.Write($"{result.Pop()} ");
            }
        }
        private static Stack<int> ReadArray()
        {
            var res = reader.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var r1 = new Stack<int>();
            for (int i = 0; i < res.Length; i++)
            {
                r1.Push(res[i]);
            }
            return r1;
        }

        private static Stack<int> ReadIntArray()
        {
            var res = reader.ReadLine().ToCharArray().Select(m => Int32.Parse(m.ToString())).ToArray();
            var r1 = new Stack<int>();
            for (int i = 0; i < res.Length; i++)
            {
                r1.Push(res[i]);
            }
            return r1;
        }

        private static int ReadInt()
        {
            return int.Parse(reader.ReadLine());
        }

    }
}
