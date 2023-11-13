using System;

namespace Array
{
    class Program
    {
        static void Main()
        {
            int[,] array =
            {
                { 2, 2, 3, 4 },
                { 5, 7, 2, 1 }
            };
            int secondLineSum = 0;
            int firstColumnProduct = 1;
            int indexSecondLine = 1;
            int indexColumnArray = 0;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                secondLineSum += array[indexSecondLine, i];
            }

            for (int j = 0; j < array.GetLength(0); j++)
            {
                firstColumnProduct *= array[j, indexColumnArray];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("Cумма второй строки - " + secondLineSum + " Произведение первого столбца - " + firstColumnProduct);
            Console.ReadKey();
        }
    }
}
