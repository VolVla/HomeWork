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
            int lineSum = 0;
            int columnProduct = 1;
            int indexLine = 2;
            int indexColumnArray = 1;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                lineSum += array[indexLine - 1, i];
            }

            for (int j = 0; j < array.GetLength(0); j++)
            {
                columnProduct *= array[j, indexColumnArray - 1];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Cумма {indexLine} строки -  {lineSum}  Произведение {indexColumnArray} столбца -  {columnProduct}");
            Console.ReadKey();
        }
    }
}
