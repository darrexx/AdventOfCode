using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day5_2
{
    class Day5_2
    {
        static void Main(string[] args)
        {
            using (var md5 = MD5.Create())
            {
                var reader = new StreamReader("../../input.txt");
                var line = reader.ReadLine();
                var i = 0;
                var counter = 0;
                var password = new string[8];
                if (line != null)
                {
                    while (counter < 8)
                    {
                        var lineWithIndex = line + i;
                        var byteArray = md5.ComputeHash(Encoding.UTF8.GetBytes(lineWithIndex));
                        var hexCharArray = BitConverter.ToString(byteArray).Replace("-", "").ToCharArray();
                        if (hexCharArray[0] == '0' && hexCharArray[1] == '0' && hexCharArray[2] == '0' &&
                            hexCharArray[3] == '0' && hexCharArray[4] == '0')
                        {
                            int index;
                            if (Int32.TryParse(hexCharArray[5].ToString(), out index))
                            {
                                if (!(index > 7 || index < 0) && password[index] == null)
                                {
                                    password[index] = hexCharArray[6].ToString();
                                    counter++;
                                }
                            }
                        }
                        i++;
                    }
                }
                foreach (var s in password)
                {
                    Console.Write(s);
                }
            }
        }
    }
}
