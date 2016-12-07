using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Day1
    {
        static void Main(string[] args)
        {
            // 0,0 bottom left
            var direction = FacingDirection.North;
            var input = args[0].Split(new[]{',',' '}, StringSplitOptions.RemoveEmptyEntries);
            int positionX = 500;
            int positionY = 500;
            for (int i = 0; i < input.Length; i++)
            {
                string rotation = input[i].Substring(0, 1);
                switch (rotation)
                {
                    case "R":
                        direction = direction.R();
                        break;
                    case "L":
                        direction = direction.L();
                        break;
                }
                int length;
                if (!Int32.TryParse(input[i].Substring(1), out length))
                {
                    throw new Exception("Invalid Input");
                }
                switch (direction)
                {
                        case FacingDirection.East:
                            positionX += length;
                            break;
                        case FacingDirection.North:
                            positionY += length;
                        break;
                        case FacingDirection.South:
                            positionY -= length;
                        break;
                        case FacingDirection.West:
                            positionX -= length;
                        break;
                }
            }
            Console.WriteLine(Math.Abs(positionX - 500) + (Math.Abs(positionY - 500)));
        }
    }
}
