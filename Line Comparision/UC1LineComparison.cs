using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    internal class UC1LineComparison
    {
        public static void GetDistance()
        {

            Console.WriteLine("enter the value of x1 ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of x2 ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y1 ");
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the value of y2 ");
            double y2 = Convert.ToInt32(Console.ReadLine());

            double Result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Result is " + Result);
        }
    }
}
