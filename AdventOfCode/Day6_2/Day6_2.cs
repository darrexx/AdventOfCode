using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_2
{
    class Day6_2
    {
        static void Main(string[] args)
        {
            var lines = new List<char[]>();
            var reader = new StreamReader("../../input.txt");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    lines.Add(line.ToCharArray());
                }
            }
            for (int i = 0; i < lines[0].Length; i++)
            {
                var letters = new List<char>();
                for (int j = 0; j < lines.Count; j++)
                {
                    letters.Add(lines[j][i]);
                }
                Console.Write(letters.GroupBy(x => x).OrderBy(x => x.Count()).Select(x => x.Key).ToArray()[0]);
            }
        }
    }
}
