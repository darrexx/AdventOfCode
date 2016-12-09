using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_1
{
    class Day4_1
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var alphabet = new[] {'a', 'b', 'c', 'd', 'e', 'f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            var reader = new StreamReader("../../input.txt");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var temp = line.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);

                    var checksum = temp[1];
                    var room = temp[0].ToCharArray();

                    var sectorIDString =
                        temp[0].Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries)[
                            temp[0].Split(new[] {'-'}, StringSplitOptions.RemoveEmptyEntries).Length - 1];
                    var sectorId = Int32.Parse(sectorIDString);

                    var letters = room.Where(x => alphabet.Contains(x)).ToArray();
                    var orderdLetters = letters.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x=> (int) x.Key).Select(x => x.Key).ToArray();
                    orderdLetters = orderdLetters.Take(5).ToArray();

                    if (new string(orderdLetters).Equals(checksum))
                    {
                        sum += sectorId;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
