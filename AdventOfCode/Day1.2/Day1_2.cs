using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1._2
{
    class Day1_2
    {
        static void Main(string[] args)
        {
            // 0,0 bottom left
            var streetGrid = new bool[1000, 1000];
            streetGrid[500, 500] = true;
            var direction = FacingDirection.North;
            var input = args[0].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var positionX = 500;
            var positionY = 500;
            for (var i = 0; i < input.Length; i++)
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
                if (!int.TryParse(input[i].Substring(1), out length))
                {
                    throw new Exception("Invalid Input");
                }
                switch (direction)
                {
                    case FacingDirection.East:
                        for (var j = 0; j < length; j++)
                        {
                            if (streetGrid[positionX + 1, positionY])
                            {
                                positionX++;
                                Console.WriteLine(Math.Abs(positionX - 500) + Math.Abs(positionY - 500));
                                return;
                            }
                            streetGrid[positionX + 1, positionY] = true;
                            positionX++;
                        }
                        break;
                    case FacingDirection.North:
                        for (var j = 0; j < length; j++)
                        {
                            if (streetGrid[positionX, positionY + 1])
                            {
                                positionY++;
                                Console.WriteLine(Math.Abs(positionX - 500) + Math.Abs(positionY - 500));
                                return;
                            }
                            streetGrid[positionX, positionY + 1] = true;
                            positionY++;
                        }
                        break;
                    case FacingDirection.South:
                        for (var j = 0; j < length; j++)
                        {
                            if (streetGrid[positionX, positionY - 1])
                            {
                                positionY--;
                                Console.WriteLine(Math.Abs(positionX - 500) + Math.Abs(positionY - 500));
                                return;
                            }
                            streetGrid[positionX, positionY - 1] = true;
                            positionY--;
                        }
                        break;
                    case FacingDirection.West:
                        for (var j = 0; j < length; j++)
                        {
                            if (streetGrid[positionX - 1, positionY])
                            {
                                positionX--;
                                Console.WriteLine(Math.Abs(positionX - 500) + Math.Abs(positionY - 500));
                                return;
                            }
                            streetGrid[positionX - 1, positionY] = true;
                            positionX--;
                        }
                        break;
                }
            }
            Console.WriteLine(Math.Abs(positionX - 500) + Math.Abs(positionY - 500));
        }
    }
}
