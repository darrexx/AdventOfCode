using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_1
{
    class Day2_1
    {
        static void Main(string[] args)
        {
            var keyPad = new KeyPad();
            var reader = new StreamReader("../../input.txt");
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line != null)
                {
                    var moves = line.ToCharArray();
                    foreach (var move in moves)
                    {
                        switch (move)
                        {
                            case 'U':
                                keyPad.U();
                                break;
                            case 'R':
                                keyPad.R();
                                break;
                            case 'D':
                                keyPad.D();
                                break;
                            case 'L':
                                keyPad.L();
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(moves), moves, null);
                        }
                    }
                    Console.Write(keyPad.GetPosition());
                }
            }
        }
    }
}
