using System;
using System.IO;
using System.Linq;

namespace _2
{
    class Program
    {
        static int Part1()
        {
            var count = 0;
            foreach (var line in File.ReadLines(@"input.txt"))
            {
                var foo = line.Split(":");
                var policy = foo[0];
                var password = foo[1];
                var bar = policy.Split(" ");
                var range = bar[0];
                var letter = bar[1][0];
                var foobar = range.Split("-");
                var min = int.Parse(foobar[0]);
                var max = int.Parse(foobar[1]);
                var occ = password.ToCharArray().Count(c => c == letter);
                if (min<=occ && occ<=max) count++;
            }   
            return count;
        }

        static int Part2()
        {
            var count = 0;
            foreach (var line in File.ReadLines(@"input.txt"))
            {
                var foo = line.Split(": ");
                var policy = foo[0];
                var password = foo[1];
                var bar = policy.Split(" ");
                var range = bar[0];
                var letter = bar[1][0];
                var foobar = range.Split("-");
                var index1 = int.Parse(foobar[0]) - 1;
                var index2 = int.Parse(foobar[1]) - 1;
                var ok = (password[index1] == letter ^ password[index2] == letter);
                if (ok) count++;
            }   
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Part2());
        }     
    }
}
