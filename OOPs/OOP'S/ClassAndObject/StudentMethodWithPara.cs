using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FellowShip.ClassAndObject
{
    class StudentMethodWithPara
    {
        
        public void dataShow(int id,String name)
        {
            Console.WriteLine("Id is:"+id);
            Console.WriteLine("Name is:"+name);
        }
        static void main(String ar[])
        {
            StudentMethodWithPara stud = new StudentMethodWithPara();
            stud.dataShow(123,"Rakesh");
            stud.dataShow(44,"Diptesh");
        }
    }
}
