using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result = 0;
            Console.WriteLine("enter the first num");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second num");
            num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                result = num1 / num2;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("exception caught is"+e);

            }
            finally
            {

                Console.WriteLine("result" + result);

            }
            Console.ReadLine();
        }
    }
}
