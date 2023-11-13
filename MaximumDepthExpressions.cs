using System;

namespace MaximumDepthExpressions
{
    class Program
    {
        static void Main()
        {
            char leftParenthesis = '(';
            char rightParenthesis = ')';
            int maximumDepthParenthesis = 0;
            int symbolCounts = 0;
            string text = "(((())))";

            foreach (var symbol in text)
            {
                if (symbol == leftParenthesis)
                {
                    symbolCounts++;

                    if (symbolCounts > maximumDepthParenthesis)
                    {
                        maximumDepthParenthesis = symbolCounts;
                    }
                }
                else if (symbol == rightParenthesis)
                {
                    symbolCounts--;

                    if (symbolCounts < 0)
                    {
                        break;
                    }
                }
            }


            if (symbolCounts != 0)
            {
                Console.WriteLine($"Не корректное скобочное выражение.");
            }
            else
            {
                Console.WriteLine($"Корректное скобочное выражение, максимальная глубина вложенных скобок {maximumDepthParenthesis}");
            }

            Console.ReadKey();
        }
    }
}
