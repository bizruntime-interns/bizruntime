using System;

namespace arithmeticexception
{
    class arithmetic
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("its denied because you must be atleast 18 years old");
            }
            else
            {
                Console.WriteLine("accessed");
            }
        }
        static void Main(string[] args)
        {
            checkAge(20);
        }
    }
}
