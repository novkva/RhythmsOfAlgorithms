using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YaAlgorithms;

public class A
{
    public delegate void CurrentTask(string doc);
    public static void Main(string[] args)
    {
        CurrentTask current;
        current = SpisochnayaForma.Do;
        current("input.txt");
    }
}