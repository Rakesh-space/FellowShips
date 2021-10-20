using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.AccessModifier
{
    class ProtectedAcessModi
    {
            protected int b = 50; //protected;
    }
    class TestModi : ProtectedAcessModi
    {
            static void main(String[] ar)
            {
                TestModi testModi = new TestModi();
                Console.WriteLine("\n Public Acess Modifier is:" + testModi.b);
            }
    }
}
