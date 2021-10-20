using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class CallByRefExample
    {
        public void value(ref int val)
        {
            val += val;
            Console.WriteLine("Fun inside value:" + val);
        }

        static void main(String args[])
        {
            int val = 50;
            CallByRefExample call = new CallByRefExample();
            Console.WriteLine("before Value is:" + val);
            call.value(ref val);
            Console.WriteLine("After Value is:" + val);
        }
    }
}
