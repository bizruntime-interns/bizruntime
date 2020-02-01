using System;



namespace sorting
{
    class Sortnumbers

    {
        static void Main(string[] args)

        {
            int[] a = {100, 82, 90,72,1,20,12,13,14};

            Array.Sort(a);
            foreach (int i in a)
            {
                Console.WriteLine("sorted ele:{0}", i);
            }
        }
    }
}
        

    