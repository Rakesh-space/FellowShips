using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.ClassAndObject
{
    class StudentMethod
    {
        int id;
        String name;

        public void show()
        {
            Console.WriteLine("Method called..");
        }

        static void main(String ar[])
        {
            StudentMethod sm = new StudentMethod();
            sm.id = 111;
            sm.name = "Ovi";
            Console.WriteLine("Id is:" +sm.id);
            Console.WriteLine("Name is:"+sm.name);
            sm.show();
        }
    }
}
