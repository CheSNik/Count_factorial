using System;

namespace Factorial2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number you want to count factorial for:");
            int fac=0, result=0;
            bool isInputRight = false;

            while (!isInputRight)
                isInputRight =  Int32.TryParse(Console.ReadLine(), out fac);
                
            result = calculateFactorial(fac);

            Console.WriteLine(result);
        }

        static int calculateFactorial(int fac)
        {
            if (fac == 1)
                return 1;
            else
                return calculateFactorial(fac - 1) * fac;
        }
    }
}
