using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MaximumDepthExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueLeftParenthesis = 0;
            int valueRightParenthesis = 0;
            int maximumDepthParenthesis = 0;
            char leftParenthesis = '(';
            char rightParenthesis = ')';
            string text = "(()())";

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == leftParenthesis){
                    valueLeftParenthesis++;
                }
                else if (text[i] == rightParenthesis){
                    valueRightParenthesis++;
                    maximumDepthParenthesis++;
                }
                if(valueLeftParenthesis < valueRightParenthesis){
                    break;    
                }
            }
            if (valueLeftParenthesis == valueRightParenthesis){
                Console.WriteLine($"Корректное скобочное выражение, максимальная глубина вложенных скобок {maximumDepthParenthesis}");
            }
            else{
                Console.WriteLine($"Не корректное скобочное выражение.");      
            } 
        }
    }
}
