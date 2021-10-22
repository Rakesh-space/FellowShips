using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueGeneric
{
    class UC2MaximumValueGeneric
    {
        public static int maxValue1(int firstValue, int secoundValue, int thirdValue)
        {
            Console.WriteLine("\n Integer Value is:");
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

        public static double maxValue2(double firstValue, double secoundValue, double thirdValue)
        {
            Console.WriteLine("\n Double Value is:");
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

        public static char maxValue3(char firstValue, char secoundValue, char thirdValue)
        {
            Console.WriteLine("\n Charecter Value is:");
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
