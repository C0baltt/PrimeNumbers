using System;

namespace PrimeNumbers
{
    public static class Input
    {
        public static ulong VerifyValue()
        {
            ulong y;
            var input = Console.ReadLine();

            while (!UInt64.TryParse(input, out y))
            {
                Console.WriteLine("Input only natural numbers, " +
                    "\n the value must be between 0 and 18 446 744 073 709 551 615");
                input = Console.ReadLine();
            }

            return y;
        }
    }
}
