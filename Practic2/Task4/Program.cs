using System;

using System.Linq;



namespace Task3

{

    internal class Program

    {

        private const int MIN_ARRAY_ITEM_VALUE = -150;

        private const int MAX_ARRAY_ITEM_VALUE = 100;

        private const int ARRAY_SIZE = 15;



        private static void Main(string[] args)

        {

            int[] numbers = new int[ARRAY_SIZE];

            InitArray(numbers);

            PrintArray(numbers);



            int minSumSequence = 0, currentSumSequence = 0;

            bool isPresentMinSum = false;

            int positiveSequenceItemsCount = 0;



            for (int i = 0; i < ARRAY_SIZE; i++)

            {

                if (numbers[i] > 0)

                {

                    currentSumSequence += numbers[i];

                    positiveSequenceItemsCount++;

                }

                else if (currentSumSequence > 0)

                {

                    if (!isPresentMinSum && positiveSequenceItemsCount > 1)

                    {

                        minSumSequence = currentSumSequence;

                        isPresentMinSum = true;

                    }

                    else if (currentSumSequence < minSumSequence && positiveSequenceItemsCount > 1)

                    {

                        minSumSequence = currentSumSequence;

                    }

                    currentSumSequence = 0;

                    positiveSequenceItemsCount = 0;

                }

            }

            Console.WriteLine("Min sum: " + minSumSequence);

            Console.ReadKey();

        }



        private static void PrintArray(int[] numbers)

        {

            for (int i = 0; i < ARRAY_SIZE; i++)

                Console.Write($"{numbers[i],5:F0}\t");

            Console.WriteLine();

        }



        private static int GenerateRandomNumber()

        {

            Random rand = new Random();

            return rand.Next(MIN_ARRAY_ITEM_VALUE, MAX_ARRAY_ITEM_VALUE);

        }



        private static int[] InitArray(int[] array)

        {

            for (int i = 0; i < ARRAY_SIZE; i++)

                array[i] = GenerateRandomNumber();

            return array;

        }

    }

}
