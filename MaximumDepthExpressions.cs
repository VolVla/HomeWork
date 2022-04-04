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
            int maximumDepthParentheses = 0; 
            int valueIncorrectParentheses = 0;
            char leftParenthesis = '(';
            char rightParenthesis = ')';
            string text = "(()())";

            foreach (char symbol in text) { 
                if (symbol == leftParenthesis){
                    valueIncorrectParentheses++;
                }
                else if (symbol == rightParenthesis){
                    maximumDepthParentheses++;
                    valueIncorrectParentheses--;
                }
            }

            if (valueIncorrectParentheses != 0){
                Console.WriteLine($"Не корректное скобочное выражение.");
            }
            else {
                Console.WriteLine($"Корректное скобочное выражение, максимальная глубина вложенных скобок {maximumDepthParentheses}");
            } 
        }
    }
}
