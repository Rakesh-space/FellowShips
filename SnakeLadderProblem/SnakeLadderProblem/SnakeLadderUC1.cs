using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProblem
{
    class SnakeLadderUC1
    {
        public void snakeLadderUC1()
        {
                int Is_Present = 1;
                Random random = new Random();
                int empInput = random.Next(0, 2);
                if (Is_Present == empInput)
                {
                    Console.WriteLine("Start the game your possition is: 0");
                    int rollDiaValue = random.Next(1, 6);

                    Console.WriteLine("Roll Dia Value is:" + rollDiaValue);
                }
                else
                {
                    Console.WriteLine(" play again");
                }
        }
    }
}
