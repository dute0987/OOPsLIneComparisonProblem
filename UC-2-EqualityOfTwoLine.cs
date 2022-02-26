using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day-8-LineComparisonUsingOOps
{
    public class UC_2_EqualityOfTwoLine
   {
        public void TwoLineEquality()
        {
             double x1 , x2 , x3 , x4 , y1 , y2 , y3 , y4 ;
            double LengthOfLine1, LengthOfLine2;

            Console.WriteLine("Enter the value for 1st line");

            Console.WriteLine("Please Enter The Value for x1 : ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for x2 : ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for y1 : ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for y2 : ");
            y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the value for 2nd line");

            Console.WriteLine("Please Enter The Value for x3 : ");
            x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for x4 : ");
            x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for y3 : ");
            y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter The Value for y4 : ");
            y4 = Convert.ToInt32(Console.ReadLine());

            LengthOfLine1 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            LengthOfLine2 = Math.Sqrt((x4 - x3) * (x4 - x3) + (y4 - y3) * (y4 - y3));
            Console.WriteLine("the length of Line1 is :- " + LengthOfLine1);
            Console.WriteLine("the length of Line2 is :- " + LengthOfLine2);

            if (LengthOfLine1.Equals(LengthOfLine2))
            {
                Console.WriteLine("The two lines are equal");
            }

        }
            
    }
}
