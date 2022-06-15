использование системы;
использование System.Collections.Generic;
использование System.Linq;
использование System.Text;
использование System.Threading.Tasks;

пространство имен SumEnteredNumbers
{
     программа занятий
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[0];
            bool isExit = false;
            строка userInput;
            строка wordExit = "exit";
            строка commandAmount = "сумма";
            
            while(isExit == false)
            {
                Console.WriteLine("Введите число\nДля вывода суммы всех введеных чисел.Введите слово "+ commandAmount + "\nДля выхода из программы.Введите слово "+ wordExit);
                userInput = Console.ReadLine(); 
                
                if (userInput == wordExit)
                {
                    Console.WriteLine("Вы вышли из программы.");
                    isExit = true;
                }
                иначе , если (userInput == commandAmount)
                {
                    int sumNumbers = 0;

                    для (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        sumNumbers += arrayNumbers[i] ;
                    }

                    Console.WriteLine(sumNumbers); 
                }
                ещё 
                {
                    Console.WriteLine("\n1)Для ввода числа напишите в чат");
                    int enterNumber;
                    enterNumber = Convert.ToInt32(userInput);
                    int[] tempArrayNumbers = new int [arrayNumbers.Length + 1];
                    tempArrayNumbers[tempArrayNumbers.Length - 1] = enterNumber;

                    для (int i = 0; i < arrayNumbers.Length; i++)
                    {
                        tempArrayNumbers[i] = arrayNumbers[i];
                    }

                    arrayNumbers = tempArrayNumbers;
                }
            }
        }
    }
}
