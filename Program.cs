using System;

namespace Day13_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find maximum Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(22, 33, 44);
            Console.WriteLine(output);

            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(12.7, 20.47, 80.56);
            Console.WriteLine(doubleoutput);

            string strigoutput = MaximumNumberCheck.MaximumStringNumber("apple", "peach", "Banana");
            Console.WriteLine(strigoutput);

        }
    }
}
