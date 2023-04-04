using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Aa
{

    private static TextWriter writer;

    public static int[] GetSum(int[] a, int[] b)
    {
        var res = new int[a.Length * 2];
        for (int i = 0; i < a.Length; i++)
        {
            res[i*2] = a[i];
            res[i*2 + 1] = b[i];

        }
        return res;
    }

    public static void Mains(string[] args)
    {
        var reader1 = Int32.Parse(Console.ReadLine());
        var reader2 = ParserToIntArray(Console.ReadLine());
        var reader3 = ParserToIntArray(Console.ReadLine());

        var res = GetSum(reader2, reader3);
        for (int i = 0; i < res.Length; i++) Console.Write($"{res[i]} ");
    }

    public static int[] ParserToIntArray(string mas)
    {
        return mas.Split(' ').Select(int.Parse).ToArray();
    }
}