using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 4, 5, 3, 1, 2 };
            ArrayMethod sort = new ArrayMethod();
            int[] array = sort.SortArray(nums);

            Console.WriteLine($"原來的陣列: {ShowArray(nums)}");
            Console.WriteLine($"排序後的陣列: {ShowArray(array)}");

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }

        static string ShowArray(int[] array)
        {
            string text = "";
            for(int i=0;i<array.Length;i++)
            {
                if (i > 0)
                    text += ", ";
                text += array[i];
            }
            return text;
        }
    }
}
