using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a natural number: ");
            var startNumber = Input.VerifyValue();
            var endNumber = Input.VerifyValue();

            CalculatorPrimreNumbers.CalculateFirstNextOddNumbers(startNumber);


        }
    }
}
