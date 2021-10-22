using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueGeneric
{
    class UC4MaximumValueGeneric
    {
        public static int maxMethod(int first,int secound,int third)
        {
            if (first > secound && first > third)
            {
                return first;
            }
            else if (secound > first && secound > third)
            {
                return secound;
            }
            else if (third>first && third>secound)
            {
                return third;
            }
            return first;
        }
    }
}
