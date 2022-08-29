using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    internal class UC2EqualsMethod
    {
        public static double lengthLine2 = 0;
        public static double lengthLine1 = 0;

        public static double EqualsMethod()
        {
            Console.WriteLine("Enter the value of x4: ");
            double x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of x3: ");
            double x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y4: ");
            double y4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y3: ");
            double y3 = Convert.ToInt32(Console.ReadLine());

            double lengthLine2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine("Length of line 2 is: " + lengthLine2);


            if (lengthLine2 == lengthLine1)
            {
                Console.WriteLine("Two lines are equal");
            }
            else
            {
                Console.WriteLine("Two lines are not equal");
            }
            return lengthLine2;
        }

    }
}
    
       

