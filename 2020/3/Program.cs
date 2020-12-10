using System;
using System.IO;
using System.Linq;

namespace _3
{
    class Program
    {
        class Slope 
        {
            public int Right { get; set; }
            public int Down {get; set;}
        }
        // Right 1, down 1.
        // Right 3, down 1. (This is the slope you already checked.)
        // Right 5, down 1.
        // Right 7, down 1.
        // Right 1, down 2.

        static Slope[] Slopes = new Slope[] {
            new Slope { Right = 1, Down = 1},
            new Slope { Right = 3, Down = 1},
            new Slope { Right = 5, Down = 1},
            new Slope { Right = 7, Down = 1},
            new Slope { Right = 1, Down = 2}
        };


        static void Main(string[] args)
        {
            var trees = new int[Slopes.Length];
            var pos = new int[Slopes.Length];

            var row = 0;
            foreach (var line in File.ReadLines(@"input.txt"))
            {
                for (var i=0; i<Slopes.Length;i++)
                {
                    var slope = Slopes[i];
                    if (row % slope.Down > 0) continue;
                    if (line[pos[i]] == '#') trees[i]++;    
                    pos[i] = (pos[i] + slope.Right) % line.Length;                                
                }
                row++;
            }
            Console.WriteLine(string.Join(",", trees.Select(m => m.ToString())));
            var product = trees.Aggregate(1, (x, y) => x * y);
            Console.WriteLine(product);
            
        }
    }
}
