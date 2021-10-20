using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class FunExample
    {
        public void output()
        {
            Console.WriteLine("Function Called..");
        }
        static void main(string args[])
        {
            FunExample fun = new FunExample();
            fun.output();
        }
    }
}
