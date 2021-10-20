using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.AccessModifier
{
    class InternalTest
    {
        protected internal string name = "Shantosh Kumar";
        protected internal void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InternalTest internalTest = new InternalTest();
            // Accessing protected internal variable  
            Console.WriteLine("Hello " + internalTest.name);
            // Accessing protected internal function  
            internalTest.Msg("Peter Decosta");
        }
    }
}
