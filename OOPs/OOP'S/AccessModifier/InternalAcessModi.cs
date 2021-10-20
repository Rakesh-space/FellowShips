using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.AccessModifier
{
    class InternalAcessModi
    {
            internal string name = "Shantosh Kumar";
            internal void Msg(string msg)
            {
                Console.WriteLine("Hello " + msg);
            }
       
        class Program
        {
            static void Main(string[] args)
            {
                InternalAcessModi internalAcessModi = new InternalAcessModi();
                // Accessing internal variable  
                Console.WriteLine("Hello " + internalAcessModi.name);
                // Accessing internal function  
                internalAcessModi.Msg("Radio Dhamal..");
            }
        }
    }
}
