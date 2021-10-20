using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{

    class FunWithParame
    {
        public void input(string msg)
        {
            Console.WriteLine(msg);
        }
        static void main(String args[])
        {
            FunWithParame fun = new FunWithParame();
            fun.input("Rakesh Musale");
        }
    }
}
