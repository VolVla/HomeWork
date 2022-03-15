using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoVarriables
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePerson = "Сергеевич";
            string surName = "Александр";
            string tempValue;

            Console.Write($"До перестановки имя {namePerson}, фамилия {surName} ");
            tempValue = surName;
            surName = namePerson;
            namePerson = tempValue;
            Console.Write($"\nДо перестановки имя {namePerson}, фамилия {surName} ");
        }
    }
}
