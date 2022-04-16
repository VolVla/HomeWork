using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenghtSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
           const int AmountNumbers = 30;
           int[] arrayNumbers = new int[AmountNumbers] { 2, 3, 2, 2, 4, 5, 4, 6, 7, 7, 7, 7, 7, 1, 2, 1, 3, 1, 1, 1, 6, 1, 4, 1, 1, 1, 2, 2, 3, 3};
           int maximumValue = arrayNumbers[0];
           int numberRepeat = 0;
           int sequenceNumbers = 3;

           for(int i = 0; i < arrayNumbers.Length - sequenceNumbers; i++){
                int value = 0;
                for (int j = 0; j < i + sequenceNumbers; j++){
                    value = arrayNumbers[i];
                }
                if (maximumValue < value){
                    maximumValue = value;
                    numberRepeat++;
                } 
           }
            Console.WriteLine($"\nСамое большое число {maximumValue}, кол-во повторений {numberRepeat}");

            foreach (int value in arrayNumbers){
               Console.Write($"{value} ");
            } 
        }
    }
}
