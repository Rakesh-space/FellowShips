using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumValueGeneric
{
    class UC5MaximumValueGeneric<T> where T:IComparable //declare the generic class here
    {
        T[] arrName;  //Genric Array declaration
        public UC5MaximumValueGeneric(T[] arrName)  //constructor to initialize to generic array
        {
            this.arrName = arrName;
        }

        public T[] sortMethod(T[] values)  //user define generic method by using Array.Sort() method
        {
            Array.Sort(values);  //here Array.Sort() method
            return values;
        }
        public T MaxValue(params T[] ar) // 
        {
            var sortValue= sortMethod(ar);
            return sortValue[^1];
        }

        public T MaxMethod()
        {
            var max=MaxValue(this.arrName);
            return max;
        }

        public void PrintMaxValue()
        {
            var max = MaxValue(this.arrName);
            Console.WriteLine("\n Maximum Values is:"+max);
        }

       /* static void main(String[] ar)
        {
            int[] arr = { 30, 2, 6 };
            UC5MaximumValueGeneric<int> gen =new UC5MaximumValueGeneric<int>(arr);
            gen.PrintMaxValue();
        }*/
    }
}
