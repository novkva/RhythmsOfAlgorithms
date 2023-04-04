using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaAlgorithms
{
    internal class ListQueue
    {
        private static TextReader reader;
        private static TextWriter writer;
        private static MyQueue _que;

        public ListQueue(string[] args)
        {
            reader = new StreamReader("input.txt");
            writer = new StreamWriter(Console.OpenStandardOutput());

            var count = ReadInt();

            _que = new MyQueue(count);
            ReadList(count);



        }
        private static int ReadInt()
        {
            return int.Parse(reader.ReadLine());
        }

        private static void ReadList(int col)
        {
            for(int i = 0; i< col; i++)
            {
                WhatLine(reader.ReadLine());            
            }
        }

        private static void WhatLine(string line)
        {
            if (line.Contains("get"))
            {
                if (_que.Peek() == null) Console.WriteLine("Error");
                else Console.WriteLine(_que.Pop());
            }
            if (line.Contains("size")) Console.WriteLine(_que.GetQSize());
            if (line.Contains("put")) _que.Push(int.Parse(line.Substring(4)));
        }

        
    }

    public class MyQueue
    {
        private int?[] queue;
        private int maxSize;
        private int head;
        private int tail;
        private int size;

        public MyQueue(int maxQueueSize)
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
