using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7_2
{
    class Day7_2
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
                    var splitted = line.Split(new[] {'[', ']'}, StringSplitOptions.RemoveEmptyEntries);
                    var possibleBAB = new List<char[]>();
                    var possibleABA = new List<char[]>();

                    for (var i = 0; i < splitted.Length; i++)
                    {
                        if (i%2 == 0)
                        {
                            if (detectABA(possibleBAB, possibleABA, splitted[i].ToCharArray()))
                            {
                                counter++;
                                break;
                            }
                        }
                        else
                        {
                            if (detectBAB(possibleABA, possibleBAB, splitted[i].ToCharArray()))
                            {
                                counter++;
                                break;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(counter);
       }

        private static bool detectBAB(List<char[]> possibleAba, List<char[]> possibleBab, char[] chars)
        {
            for (var i = 0; i < chars.Length - 2; i++)
            {
                if (chars[i] != chars[i + 1] && chars[i] == chars[i + 2])
                {
                    var aba = new[] {chars[i+1], chars[i], chars[i+1]};
                    var bab = new[] {chars[i], chars[i + 1], chars[i]};
                    possibleAba.Add(aba);
                    if (possibleBab.Count != 0)
                    {
                        foreach (var pbab in possibleBab)
                        {
                            if (bab.SequenceEqual(pbab))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }

        private static bool detectABA(List<char[]> possibleBab, List<char[]> possibleAba, char[] chars)
        {
            for (var i = 0; i < chars.Length - 2; i++)
            {
                if (chars[i] != chars[i + 1] && chars[i] == chars[i + 2])
                {
                    var bab = new[] {chars[i+1], chars[i], chars[i+1]};
                    var aba = new[] { chars[i], chars[i + 1], chars[i] };
                    possibleBab.Add(bab);
                    if (possibleAba.Count != 0)
                    {
                        foreach (var paba in possibleAba)
                        {
                            if (aba.SequenceEqual(paba))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
    }
}
