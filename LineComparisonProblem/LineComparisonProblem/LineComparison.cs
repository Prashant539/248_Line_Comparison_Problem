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

            var Length =Math.Sqrt((Math.Pow(x1-x2, 2) +Math.Pow(y2 - y1, 2)));
            Console.WriteLine("Length of line : " + Length);



        }
    }
}
