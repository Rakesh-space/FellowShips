using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueGeneric
{
    class UC3MaximumValueGeneric
    {
        public static string maxValue(string firstValue, string secoundValue, string thirdValue)
        {
            if (firstValue.CompareTo(secoundValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            else if (secoundValue.CompareTo(firstValue) > 0 && secoundValue.CompareTo(thirdValue) > 0)
            {
                return secoundValue;
            }
            else if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secoundValue) > 0)
            {
                return thirdValue;
            }
            return firstValue;
        }
    }
}
