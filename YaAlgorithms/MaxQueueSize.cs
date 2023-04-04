using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class MaxQueueSized
{
    private static TextReader reader;
    private static TextWriter writer;

    public MaxQueueSized()
    {
        reader = new StreamReader("input.txt");
        writer = new StreamWriter(Console.OpenStandardOutput());

        var commandNumber = ReadInt();
        var maxSize = ReadInt();

        var commandList = ReadList();

        reader.Close();

        var myQueue = new MyQueuea(maxSize);

        foreach (var row in commandList)
        {
            if (row.StartsWith("size"))
            {
                writer.WriteLine(myQueue.GetQSize());
            }

            if (row.StartsWith("pop"))
            {
                if (myQueue.GetQSize() > 0)
                {
                    writer.WriteLine(myQueue.Pop());
                }
                else
                {
                    writer.WriteLine("None");
                }
            }

            if (row.StartsWith("peek"))
            {
                if (myQueue.GetQSize() > 0)
                {
                    writer.WriteLine(myQueue.Peek());
                }

                else
                {
                    writer.WriteLine("None");
                }
            }

            if (row.StartsWith("push"))
            {
                var arg = int.Parse(row.Remove(0, 5));

                if (myQueue.GetQSize() == maxSize)
                {
                    writer.WriteLine("error");
                }

                myQueue.Push(arg);
            }
        }

        //var t = new List<int>();
        //var result = TwoSum(rowList, rowNumber);
        //writer.WriteLine(!result.Any() ? "None" : string.Join(" ", result));

        writer.Close();
    }

    private static int ReadInt()
    {
        return int.Parse(reader.ReadLine());
    }

    private static List<string> ReadList()
    {
        var list = reader.ReadToEnd()
            .Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
            //.Select(int.Parse)
            .ToList();

        return list;
    }

    private class MyQueuea
    {
        private int?[] queue;
        private int maxSize;
        private int head;
        private int tail;
        private int size;

        public MyQueuea(int maxQueueSize)
        {
            queue = new int?[maxQueueSize];
            maxSize = maxQueueSize;
            head = 0;
            tail = 0;
            size = 0;
        }

        public int GetQSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Push(int item)
        {
            if (size == maxSize) return;
            queue[tail] = item;
            tail = (tail + 1) % maxSize;
            size++;
        }

        public int? Pop()
        {
            if (IsEmpty()) return null;

            var result = queue[head];
            queue[head] = null;
            head = (head + 1) % maxSize;
            size--;
            return result;
        }

        public int? Peek()
        {
            if (IsEmpty()) return null;

            return queue[head];
        }
    }
}