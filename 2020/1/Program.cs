using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    class Program
    {
        static int FindPair()
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

        static int FindTriplet()
        {
            var numbers = File.ReadLines(@"input.txt").Select(int.Parse).OrderBy(m => m).ToArray();
            for (var i=0; i<numbers.Length; i++)
            {
                for (var j=i+1; j<numbers.Length; j++)
                {
                    for (var k=j+1; k<numbers.Length; k++)
                    {
                        var sum = numbers[i] + numbers[j] + numbers[k];
                        if (sum == 2020) return numbers[i] * numbers[j] * numbers[k];
                        if (sum > 2020) break;
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindPair());
            Console.WriteLine(FindTriplet());
        }
    }
}
