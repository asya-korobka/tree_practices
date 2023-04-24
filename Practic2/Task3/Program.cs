using System;

namespace Task2_1

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

            int wvar;

            int d = myarray.Length / 2;

            while (d >= 1)

            {

                for (var i = d; i < myarray.Length; i++)

                {

                    var j = i;

                    while ((j >= d) && (myarray[j - d] > myarray[j]))

                    {

                        wvar = myarray[j];

                        myarray[j] = myarray[j - 1];

                        myarray[j - 1] = wvar;

                        j = j - d;

                    }

                }



                d = d / 2;

            }

            Console.WriteLine("\n" + "\n" + "Масив пiсля сортування: ");

            foreach (int m in myarray) Console.Write(m + " ");

            System.Console.ReadLine();

        }

    }

}