using System;
using System.IO;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            var trees = 0;
            var pos = 0;
            foreach (var line in File.ReadLines(@"input.txt"))
            {
                if (line[pos] == '#') trees++;
                pos = (pos + 3) % (line.Length);
            }
            Console.WriteLine(trees);
        }
    }
}
