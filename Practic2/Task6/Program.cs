using System;



namespace Task5

{

    class Program

    {

        static void Main(string[] args)

        {

            int[][] jagged = new int[4][];

            jagged[0] = new int[6];

            jagged[1] = new int[2];

            jagged[2] = new int[4];

            jagged[3] = new int[11];



            // заповнюємо масив випадковими значеннями 

            Random rand = new Random();

            for (int i = 0; i < jagged.Length; i++)

            {

                for (int j = 0; j < jagged[i].Length; j++)

                {

                    jagged[i][j] = rand.Next(-100, 101);

                }

            }



            // виводимо масив 

            Console.WriteLine("Масив:");

            for (int i = 0; i < jagged.Length; i++)

            {

                for (int j = 0; j < jagged[i].Length; j++)

                {

                    Console.Write(jagged[i][j] + " ");

                }

                Console.WriteLine();

            }

            Console.WriteLine();



            // обчислюємо кількість ділянок з неспадаючими значеннями в кожному рядку 

            for (int i = 0; i < jagged.Length; i++)

            {

                int count = 0;

                int prev = jagged[i][0];

                bool inSequence = false;



                for (int j = 1; j < jagged[i].Length; j++)

                {

                    if (jagged[i][j] >= prev)

                    {

                        if (!inSequence)

                        {

                            inSequence = true;

                            count++;

                        }

                    }

                    else

                    {

                        inSequence = false;

                    }



                    prev = jagged[i][j];

                }



                Console.WriteLine($"Рядок {i}: {count} кiлькiсть дiлянок");

            }



            Console.ReadLine();

        }

    }

}