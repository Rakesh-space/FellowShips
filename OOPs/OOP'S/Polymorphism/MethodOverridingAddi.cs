using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_S.Polymorphism
{
    class MethodOverloadingAddi
    {
        public void add(int a, int b)
        {
            Console.WriteLine("Integer Addition:" + (a + b));
        }

        public void add(float p, float q)
        {
            Console.WriteLine("Integer Addition:" + (p + q));
        }
        static void main(String[] ar)
        {
            MethodOverloadingAddi methodOverloadingAddi = new MethodOverloadingAddi();
            methodOverloadingAddi.add(2,3);
            methodOverloadingAddi.add(2.1f, 3.9f);
        }
    }
}
