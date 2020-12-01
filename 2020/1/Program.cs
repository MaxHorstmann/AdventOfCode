using System;
using System.IO;
using System.Collections.Generic;

namespace _1
{
    class Program
    {
        static int Do()
        {
            var hs = new HashSet<int>();
            foreach (var line in File.ReadLines(@"input.txt"))
            {
                var a = int.Parse(line);
                var b = 2020-a;
                if (hs.Contains(b)) return a * b;
                hs.Add(a);
            }
            throw new InvalidOperationException("not found");
        }
        static void Main(string[] args)
        {
            var n = Do();
            Console.WriteLine(n);
        }
    }
}
