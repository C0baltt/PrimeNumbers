using System.Collections.Generic;

namespace PrimeNumbers
{
    class CalculatorPrimreNumbers
    {
        static List<ulong> primeNumbers = new(1);

        static int counter = 0, period = 0;

        ulong GetFirstDigitOfNumbers(ulong endNumber)
        {
            var firstDigitOfNumber = endNumber % 10;
            return endNumber += CalculateFirstNextOddNumbers(firstDigitOfNumber);
        }

        ulong GetFirstDigitOfNumbers(ulong startNumber, ulong endNumber)
        {
            var firstDigitOfNumber = startNumber % 10;
            return startNumber += CalculateFirstNextOddNumbers(firstDigitOfNumber);
        }

        ulong CalculateFirstNextOddNumbers(ulong nextOddNumber)
        {
            //switch (nextOddNumber)
            //{
            //    case 0:
            //    case 2:
            //    case 6:
            //    case 8:
            //        nextOddNumber += 1;
            //        break;

            //    case 1:
            //    case 5:
            //    case 7:
            //    case 9:
            //        nextOddNumber += 2;
            //        break;

            //    case 3:
            //        nextOddNumber += 4;
            //        break;

            //    case 4:
            //        nextOddNumber += 3;
            //        break;
            //}

            switch (nextOddNumber)
            {
                case 0:
                    nextOddNumber = 1;
                    period = 2;
                    counter = 2;
                    break;

                case 1:
                case 2:
                    nextOddNumber = 3;
                    period = 4;
                    counter = 3;
                    break;

                case 3:
                case 4:
                case 5:
                case 6:
                    nextOddNumber = 7;
                    period = 2;
                    counter = 0;
                    break;

                case 7:
                case 8:
                    nextOddNumber = 9;
                    period = 2;
                    counter = 1;
                    break;

                case 9:
                    nextOddNumber = 11;
                    period = 2;
                    counter = 2;
                    break;
            }

            return nextOddNumber;
        }

        void CalculatePrimeNumbers()
        {

        }

        void CalculateSequenceOfPrimeNumbers()
        {
            if (counter >= 3) 
            {
                counter = 0;
                period = 4;
                return;
            }

            period = 2;
            counter++;
        }

    }
}
