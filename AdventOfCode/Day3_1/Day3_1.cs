using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_1
{
    class Day3_1
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
                    var stringNumbers = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var numbers = new int[3];
                    for (var i = 0; i < stringNumbers.Length; i++)
                    {
                        numbers[i] = Int32.Parse(stringNumbers[i]);
                    }
                    var maxIndex = Array.IndexOf(numbers, numbers.Max());
                    switch (maxIndex)
                    {
                        case 0:
                            if (numbers[1] + numbers[2] > numbers[0])
                            {
                                counter++;
                            }
                            break;
                        case 1:
                            if (numbers[0] + numbers[2] > numbers[1])
                            {
                                counter++;
                            }
                            break;
                        case 2:
                            if (numbers[1] + numbers[0] > numbers[2])
                            {
                                counter++;
                            }
                            break;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
