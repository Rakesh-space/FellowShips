using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class LineComparisonUC2
    {
        public void lineComparisonUC2()
        {
            double x1, y1, x2, y2;
            double len, length;
            double point1, point2;

            ////user input taking the input first lenth
            Console.WriteLine("please enter the value of x and y co-ordinates:");
            Console.WriteLine("enter the value point x1  :");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y1  :");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point x2  :");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y2  :");
            y2 = Convert.ToInt32(Console.ReadLine());


            // calculate first length
            point1 = Math.Pow((x2 - x1), 2); //calculate only x-co-ordinate value
            point2 = Math.Pow((y2 - y1), 2); //calculate only y-co-ordinate value

            len = point1 + point2;
            length = Math.Sqrt(len);

            Console.WriteLine("length is :" + length);

            if (point1 == point2) //check the condition both are equal or not
            {
                Console.WriteLine("both are equal ");
            }
            else
            {
                Console.WriteLine("line 2 is reater than 1");
            }
        }
    }
}
