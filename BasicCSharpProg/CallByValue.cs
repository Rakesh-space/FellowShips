using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.BasicCSharpProg
{
    class CallByValue
    {
        public void value(int val)
        {
            val += val;
            Console.WriteLine("Value inside fun:" + val);
        }
        static void main(String args[])
        {
            int val = 50;
            CallByValue call = new CallByValue();
            Console.WriteLine("Before the value:" + val);
            call.value(val);
            Console.WriteLine("After the Value:" + val);
        }
    }

}
