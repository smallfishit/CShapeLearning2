using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "abc";
            string str2 = "abc";
            int int1 = 1;
            int int2 = 1;
            StringBuilder sb1 = new StringBuilder("abc");
            StringBuilder sb2 = new StringBuilder("abc");
            Console.WriteLine("Reference equal for string: " + ReferenceEquals(str1, str2)); //True
            str1 += "d";
            str2 += "d";
            Console.WriteLine("Reference equal for string: " + ReferenceEquals(str1, str2)); //True
            Console.WriteLine("Reference equal for int: " + ReferenceEquals(int1, int2)); //False
            Console.WriteLine("Reference equal for StringBuilder: " + ReferenceEquals(sb1, sb2)); //False

            /** 可參考以下網頁，還沒完全看懂
             * https://docs.microsoft.com/zh-tw/dotnet/api/system.object.referenceequals?view=net-6.0
            **/

            Console.WriteLine();
            Console.WriteLine("請輸入任意鍵結束!");
            Console.ReadKey();
        }
    }
}
