using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.AccessModifier
{
    class PublicAcessModi
    {
        public int a = 20; //public;
        
    }
    class TestModi : PublicAcessModi
    {

        static void main(String[] ar)
        {
            TestModi testModi=new TestModi();
            Console.WriteLine("\n Public Acess Modifier is:"+ testModi.a);   
        }
    }
}
