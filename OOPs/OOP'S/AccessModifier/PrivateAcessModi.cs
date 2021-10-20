using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.AccessModifier
{
    class PrivateAcessModi
    {
        private int a = 10;
        static void main(String[] args)
        {
            PrivateAcessModi privateAcessModi = new PrivateAcessModi();
            Console.WriteLine("\n Private Vaiable is:"+ privateAcessModi.a);
        }
    }
}
