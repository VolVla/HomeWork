using System;

namespace MaximumDepthExpressions
{
    class Program
    {
        static void Main()
        {
            int valueLeftParenthesis = 0;
            int valueRightParenthesis = 0;
            int maximumDepthParenthesis = 0;
            char leftParenthesis = '(';
            char rightParenthesis = ')';
            string text = "(()())";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == leftParenthesis)
                {
                    valueLeftParenthesis++;
                    
                    if (i != text.Length-1 && text[i+1] != leftParenthesis)
                    {
                        maximumDepthParenthesis++;
                    }
                }
                else if (text[i] == rightParenthesis)
                {
                    valueRightParenthesis++;
                }
                if(valueLeftParenthesis < valueRightParenthesis)
                {
                    break;    
                } 
            }
            
            if (valueLeftParenthesis == valueRightParenthesis)
            {
                Console.WriteLine($"Корректное скобочное выражение, максимальная глубина вложенных скобок {maximumDepthParenthesis}");
            }
            else
            {
                Console.WriteLine($"Не корректное скобочное выражение.");      
            } 
        }
    }
}
