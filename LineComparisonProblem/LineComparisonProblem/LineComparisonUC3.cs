using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class LineComparisonUC3
    {
        public void lineComparisonUC3()
        {
            double x1, y1, x2, y2;
            double len, length;
            double point1, point2;
            double x3, y3, x4, y4;
            double len2, length2;
            double point3, point4;
            ////user input taking the input first lenth
            Console.WriteLine("please enter first length value");
            Console.WriteLine("enter the value point x1  :");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y1  :");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point x2  :");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y2  :");
            y2 = Convert.ToInt32(Console.ReadLine());

            ////user input taking the input Second lenth
            Console.WriteLine("please enter Second length value");
            Console.WriteLine("enter the value point x3  :");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y3  :");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point x4  :");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y4  :");
            y4 = Convert.ToInt32(Console.ReadLine());

            // calculate first length
            point1 = Math.Pow((x2 - x1), 2);
            point2 = Math.Pow((y2 - y1), 2);
            len = point1 + point2;
            length = Math.Sqrt(len);
            Console.WriteLine("length is :" + length);

            // calculate Second length
            point3 = Math.Pow((x3 - x3), 2);
            point4 = Math.Pow((y4 - y4), 2);
            len2 = point3 + point4;
            length2 = Math.Sqrt(len2);
            Console.WriteLine("length is :" + length2);



            if (length == length2) //comparing both lenght
            {
                Console.WriteLine("both are equal ");
            }
            else if (length > length2) //comparing greter than both of varibales
            {
                Console.WriteLine("lines one is greater then two");
            }
            else
            {
                Console.WriteLine("line 2 is reater than 1");
            }
        }
    }
}
