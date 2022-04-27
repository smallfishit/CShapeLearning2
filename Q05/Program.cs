using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] nums = new int[] { 4, 1, 2, 1, 2 };
                NumberAnalysis analysis = new NumberAnalysis();
                int num = analysis.SingleNumber(nums);

                Console.WriteLine($"原來的陣列: {ShowArray(nums)}");
                Console.WriteLine($"落單的數字: {num}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }

        static string ShowArray(int[] array)
        {
            string text = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0)
                    text += ", ";
                text += array[i];
            }
            return text;
        }
    }
}
