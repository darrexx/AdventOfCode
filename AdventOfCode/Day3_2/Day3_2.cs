using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_2
{
    class Day3_2
    {
        static void Main(string[] args)
        {
            var counter = 0;
            var reader = new StreamReader("../../input.txt");
            var numbers = new List<int>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var stringNumbers = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    var numbersArray = new int[3];
                    for (var i = 0; i < stringNumbers.Length; i++)
                    {
                        numbersArray[i] = Int32.Parse(stringNumbers[i]);
                    }
                    numbers.AddRange(numbersArray);
                }
            }
            var j = 0;
            while (j < numbers.Count)
            {
                if (CalculateTriangle(numbers, j))
                {
                    counter++;
                }
                j++;
                if (CalculateTriangle(numbers, j))
                {
                    counter++;
                }
                j++;
                if (CalculateTriangle(numbers, j))
                {
                    counter++;
                }
                j += 7;
            }
            Console.WriteLine(counter);
        }

        private static bool CalculateTriangle(List<int> numberList, int index)
        {
            var numbers = new int[3];
            numbers[0] = numberList[index];
            numbers[1] = numberList[index + 3];
            numbers[2] = numberList[index + 6];
            var maxIndex = Array.IndexOf(numbers, numbers.Max());
            switch (maxIndex)
            {
                case 0:
                    if (numbers[1] + numbers[2] > numbers[0])
                    {
                        return true;
                    }
                    break;
                case 1:
                    if (numbers[0] + numbers[2] > numbers[1])
                    {
                        return true;
                    }
                    break;
                case 2:
                    if (numbers[1] + numbers[0] > numbers[2])
                    {
                        return true;
                    }
                    break;
            }
            return false;
        }
    }
}
