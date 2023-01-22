using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class LineComparison
    {
        public void LineLength()
        {
            Console.WriteLine("Enter the First Co-ordinate x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Co-ordinate x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the First Co-ordinate y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Second Co-ordinate y2: ");
            int y2 = Convert.ToInt32(Console.ReadLine());

            var Length1 =Math.Sqrt((Math.Pow(x1-x2, 2) +Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Length of line : " + Length1);

            Console.WriteLine("Enter the third Co-ordinate x3: ");
            int x3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Fourth Co-ordinate x4: ");
            int x4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third Co-ordinate y3: ");
            int y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third Co-ordinate y4: ");
            int y4 = Convert.ToInt32(Console.ReadLine());

            var Length2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)));
            Console.WriteLine("Length of line : " + Length2);

            if(Length1 == Length2)
            {
                Console.WriteLine("The Two Lines are Equal");

            }
            else
            {
                Console.WriteLine("The Two Lines are not Equal");
            }


        }
    }
}
