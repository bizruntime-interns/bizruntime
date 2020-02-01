using System;

namespace casting
{
    class typecasting
    {
        static void Main(string[] args)
        {
            double a = 9.0;
           int b = (int) a;      

            Console.WriteLine("the variable a is converted to int i.e "+a);      
            Console.WriteLine("the variable b is already int "+b);


            int q = 10;
            double w = 5.25;
            bool e = true;

            Console.WriteLine(Convert.ToString(q));      
            Console.WriteLine(Convert.ToInt32(w));  
            Console.WriteLine(Convert.ToString(e));
        }
    }
}
