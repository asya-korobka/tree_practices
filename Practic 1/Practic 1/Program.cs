using System;

using System.Collections.Generic;

using System.Globalization;





namespace ConsoleApp1

{

    class Program

    {

        static void Main(string[] args)

        {



            Console.WriteLine("Введiть число X: ");

            string number = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(number) || !int.TryParse(number, out int x))

            {

                Console.WriteLine("Введенi данi не являються числом, або не є цiлим числом");

                Console.ReadLine();

                return;

            }

            int fnum = 1;

            double y = 0;

            if (x <= 5)

            {

                fnum = 1;

                y = (Math.Pow(x, 3) / 3) + 10;



            }

            else if (x > 6 && x <= 12)

            {

                fnum = 2;

                double pr = 1;

                for (int i = 7; i <= x; i++)

                {

                    pr *= Math.Pow((i - 4), 2);

                }

                y = 6 * pr;

            }

            else

            {

                fnum = 3;

                double sum = 0;

                for (int i = 13; i <= x; i++)

                {

                    sum += Math.Pow(i, 3) / 3;

                }

                y = sum;

            }

            Console.WriteLine($"Y рахується за {fnum} формулою\nY={y}");



            Console.ReadLine();

        }

    }

}