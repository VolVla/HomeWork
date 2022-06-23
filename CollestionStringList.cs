using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 1, 2, 1 };
            int[] secondArray = new int[] { 3, 2, 6 };
            List<int> arrayList = new List<int>();

            AddArrayInCollection(arrayList, firstArray);
            AddArrayInCollection(arrayList, secondArray);

            foreach (int element in arrayList)
            {
                Console.WriteLine($"{element}");
            }
        }

        static void AddArrayInCollection(List<int> arrayList,int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (arrayList.Contains(array[i]) == false)
                {
                    arrayList.Add(array[i]);
                }
            }
        }
    }
}
