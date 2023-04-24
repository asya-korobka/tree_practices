using System;

using System.Collections.Generic;

using System.Globalization;





namespace ConsoleApp1

{

    class Program

    {



        static string IntToBinary(int number)

        {



            int remainder;

            string result = string.Empty;

            while (number > 0)

            {

                remainder = number % 2;

                number /= 2;

                result = remainder.ToString() + result;

            }

            return result;

        }



        static string IntToOctal(int number)

        {



            int Octal = 0, i = 1;

            string result = string.Empty;

            for (int j = number; j > 0; j = j / 8)

            {

                Octal = Octal + (j % 8) * i;

                i *= 10;

                number /= 8;

                result = Octal.ToString();

            }

            return result;

        }





        static void Main(string[] args)

        {



            char key;

            do

            {

                Console.WriteLine("\nПрограма переведення числа з десяткової системи числення\n" +

                    "Оберiть систему числення:\n1. Двiйкова\n2. Восьмирична\nn. Вихiд");



                key = Console.ReadKey().KeyChar;



                if (key == '1' || key == '2')

                {

                    Console.WriteLine("\nВведiть число для конвертацiї: ");

                    var numberString = Console.ReadLine();

                    if (!int.TryParse(numberString, out var number))

                    {

                        Console.WriteLine("Введенi даннi не цiле число!!!");

                        continue;

                    }

                    var result = key == '1' ? IntToBinary(number) : IntToOctal(number);

                    Console.WriteLine($"Результат: {result}");

                }







            } while (key != 'n');

            Console.ReadLine();

        }

    }

}