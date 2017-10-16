using System;

namespace ConsoleApplication
{
    public class Program
    {
        //aray filling function
        private static int[] arrFill(int arrLength)
        {
            int rndLimit = 100;
            int[] randElemArr = new int[arrLength];
            Random rnd = new Random();
            for (int i = 0; i < arrLength; i++) randElemArr[i] = rnd.Next(rndLimit);
            foreach (int n in randElemArr)
                Console.Write(" {0}", n);
            return randElemArr;
        }

        public static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int oddNum = 0;
            int evenNum = 0;
            int arrLength = 10;
            float elemSum = 0;
            Console.Write("Considering following range: ");

            //populating an array 
            int[] myArray = arrFill(arrLength);

            //finding of arithmetic mean, min & max values
            j = myArray[i];
            k = myArray[i];
            for (i = 0; i < myArray.Length; i++)
            {
                //min & max finding
                if (myArray[i] <= j)
                    j = myArray[i];
                if (myArray[i] >= k)
                    k = myArray[i];

                //odd & even values separation
                if (myArray[i] % 2 != 0)
                    oddNum++;
                else
                    evenNum++;

                //computation of an amount of all values comprise in the array
                //the arithmetic mean inself is computed within the final console output expression
                elemSum += myArray[i];
            }

            Console.WriteLine("\n\nAn arithmetic mean would be {0}\n\nThe max and min values of the range are {1} and {2} respectively.\n\nThere are {3} odd and {4} even numbers within the range."
                                , (elemSum / myArray.Length), j, k, oddNum, evenNum);
            Console.ReadKey();
        }
    }
}