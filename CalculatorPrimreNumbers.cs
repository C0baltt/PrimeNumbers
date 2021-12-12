using System.Collections.Generic;

namespace PrimeNumbers
{
    public class CalculatorPrimreNumbers
    {
        static List<ulong> primeNumbers = new(1);

        ulong _startNumber, _endNumber;

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

        public ulong CalculateFirstNextOddNumbers(ulong nextOddNumber)
        {
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

        void CalculatePrimeNumbers(ulong start, ulong end)
        {
            


            CalculateCounter();




        }

        void CalculatePrimeNumber()
        {
            //for (int i = 0; i < primeNumbers.Count; i++)
            //{

            //}

            //while (number < (ulong)primeNumbers.Count)

            var number = primeNumbers[0];
            while (true)
            {
                //(number *= number) < (ulong)primeNumbers.Count

                var _item = number;

                if ((_item *= _item) < primeNumbers[primeNumbers.Count - 1] )
                {
                    List<ulong> _primeNumbers = primeNumbers.GetRange(0, primeNumbers.FindIndex(i));

                    foreach (var _number in primeNumbers)
                    {

                    }
                } 
            }
        }

        int CalculateCounter()
        {
            if (counter >= 3) 
            {
                counter = 0;
                period = 4;
                return period;
            }

            period = 2;
            counter++;

            return period;
        }

    }
}
