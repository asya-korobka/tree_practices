using System;



class Program

{

    static int GenerateRandomNumber(int min, int max)

    {

        Random rand = new Random();

        return rand.Next(min, max + 1);

    }



    static int[,] FillMatrixRandNumbers(int size, int minValue, int maxValue)

    {

        int[,] matrix = new int[size, size];

        for (int i = 0; i < size; i++)

        {

            for (int j = 0; j < size; j++)

            {

                int randNumber = GenerateRandomNumber(minValue, maxValue);

                matrix[i, j] = randNumber;

            }

        }

        return matrix;

    }



    static void PrintMatrix(int[,] matrix, int size)

    {

        for (int i = 0; i < size; i++)

        {

            for (int j = 0; j < size; j++)

            {

                Console.Write("{0,5}", matrix[i, j]);

            }

            Console.WriteLine();

        }

    }



    static int[,] MatrixDiagonalReverse(int[,] matrix, int size)

    {

        int buffer;

        for (int i = 0; i < size; i++)

        {

            for (int j = 0; j < i; j++)

            {

                buffer = matrix[i, j];

                matrix[i, j] = matrix[j, i];

                matrix[j, i] = buffer;

            }

        }

        return matrix;

    }



    static void Main(string[] args)

    {

        const int minItemValue = -100;

        const int maxItemValue = 100;



        Console.Write("Введiть розмiр матрицi: ");

        int matrixSize = int.Parse(Console.ReadLine());



        int[,] matrix = FillMatrixRandNumbers(matrixSize, minItemValue, maxItemValue);



        PrintMatrix(matrix, matrixSize);



        matrix = MatrixDiagonalReverse(matrix, matrixSize);



        Console.WriteLine();



        PrintMatrix(matrix, matrixSize);



        Console.ReadKey();

    }

}
