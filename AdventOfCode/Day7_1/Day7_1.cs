using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_1
{
    class Day7_1
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var reader = new StreamReader("../../input.txt");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var lineArray = line.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
                    var supportsTLS = false;
                    for (var i = 0; i < lineArray.Length; i++)
                    {
                        if (i%2 == 0 && DetectABBA(lineArray[i]))
                        {
                            supportsTLS = true;
                        }
                        else
                        {
                            if (DetectABBA(lineArray[i]))
                            {
                                supportsTLS = false;
                                break;
                            }
                        }
                    }
                    if (supportsTLS)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        private static bool DetectABBA(string line)
        {
            var chars = line.ToCharArray();
            for (var i = 0; i < chars.Length - 3; i++)
            {
                if (chars[i] != chars[i + 1] && chars[i + 1] == chars[i + 2] && chars[i] == chars[i + 3])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
