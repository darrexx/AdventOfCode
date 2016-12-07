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
                var previousX = positionX;
                var previousY = positionY;
                switch (direction)
                {
                    case FacingDirection.East:
                        positionX += length;
                        if (streetGrid[positionX, positionY])
                        {
                            break;
                        }
                        streetGrid[positionX, positionY] = true;
                        break;
                    case FacingDirection.North:
                        positionY += length;
                        if (streetGrid[positionX, positionY])
                        {

                        }
                        streetGrid[positionX, positionY] = true;
                        break;
                    case FacingDirection.South:
                        positionY -= length;
                        if (streetGrid[positionX, positionY])
                        {

                        }
                        streetGrid[positionX, positionY] = true;
                        break;
                    case FacingDirection.West:
                        positionX -= length;
                        if (streetGrid[positionX, positionY])
                        {

                        }
                        streetGrid[positionX, positionY] = true;
                        break;
                }
                for (int j = previousY + 1; j <= positionY; j++)
                {
                    for (var k = previousX + 1; k >= positionX; k++)
                    {
                        if (streetGrid[j, k])
                        {

                        }
                        streetGrid[j, k] = true;
                    }
                }
            }
            Console.WriteLine(Math.Abs(positionX - 500) + (Math.Abs(positionY - 500)));
        }
    }
}
