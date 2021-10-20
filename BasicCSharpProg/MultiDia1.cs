using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class MultiDia1
    {
        static void main(String ar[])
        {
            int[,] arr = new int[3, 3] { { 2, 1, 7 }, { 1, 3, 2 }, { 5, 4, 3 } };

            Console.WriteLine("Multi Diamentional Array is:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(arr[i, j]);
                }
            }
        }
    }
}
