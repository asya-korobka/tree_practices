using System;

class Program

{

    static void Main()

    {

        Console.WriteLine("Введiть текст:");

        string text = Console.ReadLine().ToLower();

        // перетворюємо введений текст до нижнього регістру

        int[] count = new int[1103 - 1040 + 1];

        // масив для зберігання кількості повторень кожного символу

        int maxCount = 0;

        // змінна для зберігання максимальної кількості повторень

        string maxChars = "";

        // змінна для зберігання символів з максимальною кількістю повторень

        foreach (char c in text)

        {

            int index = (int)c - 1040;

            // визначаємо індекс для поточного символу

            if (index >= 0 && index < count.Length)

            {

                count[index]++;

                // збільшуємо кількість повторень для поточного символу

                if (count[index] > maxCount)

                {

                    maxCount = count[index];

                    // оновлюємо максимальну кількість повторень

                    maxChars = c.ToString();

                    // оновлюємо символ з максимальною кількістю повторень

                }

                else if (count[index] == maxCount)

                {

                    maxChars += ", " + c.ToString();

                    // додаємо символ до списку з максимальною кількістю повторень

                }

            }

        }

        Console.WriteLine($"Максимальна кiлькiсть повторень: {maxCount}");

        Console.WriteLine($"Символ(и) з максимальною кiлькiстю повторень: {maxChars}");

    }

}
