using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    class Program
    {
        static void Main(string[] args){
            const int AmountNumbers = 5;
            int[] array = new int[AmountNumbers] { 1, 2, 3, 4, 5};
            Shuffle(array);
            OutputArray(array);}

        static void Shuffle(int[] array){
            Random random = new Random();
            int lenghtArray = array.Length;

            for (int i = 0; i < lenghtArray; i++){
                Swap(array, i, random.Next(lenghtArray));}}

        static void Swap(int[] array, int firstNumber, int secondNumber){
            int temporaryValue = array[firstNumber];
            array[firstNumber] = array[secondNumber];
            array[secondNumber] = temporaryValue;}

        static void OutputArray(int[] array){
            foreach(int numbers in array){
                Console.Write($"{numbers} ");}}
    }
}
