using System;

namespace Task2

{

    class Program

    {

        static void Main(string[] args)

        {

            int[] myarray = new int[30];

            Console.WriteLine("Введiть елементи масиву: ");

            for (int i = 0; i < 30; i++)

            {

                Console.WriteLine("Елемент № " + i);

                string text = Console.ReadLine();

                myarray[i] = int.Parse(text);

            }

            int wvar = myarray[0];

            for (int i = 1; i < 30; i++)

            {

                for (var j = 0; j < 29; j++)

                {

                    if (myarray[j] > myarray[j + 1])

                    {

                        wvar = myarray[j];

                        myarray[j] = myarray[j + 1];

                        myarray[j + 1] = wvar;

                    }

                }

            }

            Console.WriteLine("\n" + "\n" + "Масив пiсля сортування: ");

            foreach (int m in myarray) Console.Write(m + " ");

            System.Console.ReadLine();

        }

    }

}