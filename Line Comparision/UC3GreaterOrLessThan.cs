using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparision
{
    internal class UC3GreaterOrLessThan
    {
        public static double lenthLine1 = UC1LineComparison.GetDistance();

        public static double lenthLine2 = UC2EqualsMethod.EqualsMethod();



        public static void compare()
        {

            if (lenthLine2 > lenthLine1)
            {
                Console.WriteLine("Line 2 is greater than Line 1");
            }
            else
            {
                Console.WriteLine("Line 2 is smaller than Line 1");
            }
        }
    }
}
