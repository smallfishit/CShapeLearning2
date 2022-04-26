using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal length = 0, width = 0, height = 0;

            try
            {
                Console.Write("Enter height of box (meter): ");
                string text = Console.ReadLine();
                height = decimal.Parse(text);
                Console.Write("Enter length of box (meter): ");
                text = Console.ReadLine();
                length = decimal.Parse(text);
                Console.Write("Enter width of box (meter): ");
                text = Console.ReadLine();
                width = decimal.Parse(text);

                VolumnCalculator volumnCal = new VolumnCalculator();
                decimal volumn = volumnCal.CalculateVolumn(length, width, height);
                Console.WriteLine($"Volume (cubic meters): {volumn}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"發生例外：{ex.Message}");
            }

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
