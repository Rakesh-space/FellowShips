using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    class LineComparisonUC1
    {
        public void lineComparisonUC1()
        {
            double x1, y1, x2, y2;
            double len, length;
            double point1, point2;

            Console.WriteLine("enter the value point x1:");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y1:");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point x2:");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value point y2:");
            y2 = Convert.ToInt32(Console.ReadLine());


            point1 = Math.Pow((x2 - x1), 2); //calculate only x-co-ordinate value
            point2 = Math.Pow((y2 - y1), 2); //calculate only y-co-ordinate value

            len = point1 + point2;
            length = Math.Sqrt(len);

            Console.WriteLine("Length of point x2,x1 and y2,y1 is  :"+length);  //calculate the length of x and y co-ordinate
        }
    }
}
