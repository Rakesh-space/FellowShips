using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class MultiDiaArray
    {
        static void main(String[] arg)
        {
            int[,] ar = new int[3, 3];

            ar[0, 1] = 10;
            ar[1, 2] = 20;
            ar[3, 2] = 30;

            Console.WriteLine("Multi Diamentional Array is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.WriteLine(ar[i, j]);
                }
            }
        }
    }
}
