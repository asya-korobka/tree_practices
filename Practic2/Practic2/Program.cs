using System;



namespace Task1

{

    internal class Program

    {

        public static void Main(string[] args)

        {

            int[] myArray = new int[10];

            int[] result = new int[myArray.Length];

            int count = 0;

            Console.WriteLine("Введiть 10 цiлих чисел для масиву:");

            for (int i = 0; i < myArray.Length; i++)

            {

                int input;

                while (!int.TryParse(Console.ReadLine(), out input))

                {

                    Console.WriteLine("Введiть цiле число:");

                }

                myArray[i] = input;

            }



            count = myArray.Count(n => n == 0);



            Console.WriteLine(string.Join(", ", myArray));

            int maxIndex = 0;

            int firstZeroIndex = -1;

            int secondZeroIndex = -1;



            for (int i = 1; i < myArray.Length; i++)

            {

                if (myArray[i] > myArray[maxIndex])

                {

                    maxIndex = i;

                }

            }

            Console.WriteLine("Iндекс максимального елементу: " + maxIndex);

            for (int i = 0; i < myArray.Length; i++)

            {

                if (myArray[i] == 0)

                {

                    if (firstZeroIndex == -1)

                    {

                        firstZeroIndex = i;

                    }

                    else if (secondZeroIndex == -1)

                    {

                        secondZeroIndex = i;

                    }

                }

            }



            if (firstZeroIndex == -1 || secondZeroIndex == -1)

            {

                Console.WriteLine("Недостатньо нулiв у масивi");

                return;

            }



            int product = 1;



            for (int i = firstZeroIndex + 1; i < secondZeroIndex; i++)

            {

                product *= myArray[i];

            }



            Console.WriteLine("Добуток елементiв мiж першими i другими нулями: " + product);





            int oddIndex = 0;

            int evenIndex = myArray.Length / 2;



            for (int i = 0; i < myArray.Length; i++)

            {

                if (i % 2 == 0)

                {



                    result[evenIndex++] = myArray[i];

                }

                else

                {



                    result[oddIndex++] = myArray[i];

                }

            }





            Console.WriteLine("Початковий масив:");

            Console.WriteLine(string.Join(", ", myArray));



            Console.WriteLine("Новий масив:");

            Console.WriteLine(string.Join(", ", result));

        }

    }

}