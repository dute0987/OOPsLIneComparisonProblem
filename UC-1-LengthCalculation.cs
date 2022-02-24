using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_8_LineComparisonUsingOOps
{
    public class UC_1_LengthCalculation
    {
     public void CalculationOfLength()
        {
            double x1, x2, y1, y2;
            double LengthOfLine;

            Console.WriteLine("Please Enter The Value for x1 : ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for x2 : ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for y1 : ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for y2 : ");
            y2 = Convert.ToInt32(Console.ReadLine());

            LengthOfLine = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("the length of Line is :- " + LengthOfLine);
        }
    }
}
