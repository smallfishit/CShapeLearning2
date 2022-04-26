# C#練習專案2
  
## C#基本練習題題庫2  
  
練習1:  
專案：Q01  
測試：Q01.Test  
請實作一個「給定正整數變數長、寬、高，計算並顯示長方體體積的功能」。以下為使用者操作程式時，假設給定長8公尺、寬12公尺、高10公尺之變數，在畫面上應該要看到的資訊：  
Enter height of box (meter): 8  
Enter length of box (meter): 12  
Enter width of box (meter): 10  
Volume (cubic meters): 960  
  
練習2:  
專案：Q02  
測試：Q02.Test  
承上題，請將長、寬、高以及計算結果，改為可接受浮點數的型別。  
Enter height of box (meter): 8.5  
Enter length of box (meter): 12.5  
Enter width of box (meter): 10.5  
Volume (cubic meters): 1115.625  
  
練習3:  
請執行以下程式，然後簡單回答為什麼執行結果會依序是True, False, False?  
```
using System;  
using System.Text;
namespace ConsoleApp
{
	class Program
    {
		static void Main(string[] args)
        {
			string str1 = "abc";
			string str2 = "abc";
			int int1 = 1;
			int int2 = 1;
			StringBuilder sb1 = newStringBuilder("abc");
			StringBuilder sb2 = newStringBuilder("abc");
			Console.WriteLine("Reference equal for string: " + ReferenceEquals(str1, str2));
			Console.WriteLine("Reference equal for int: " + ReferenceEquals(int1, int2));
			Console.WriteLine("Reference equal for StringBuilder: " + ReferenceEquals(sb1, sb2));
        }
    }
}
```

練習4:
給定一個任意非空的整數陣列nums，請將陣列中的所有元素由小到大排序，然後輸出排序後的陣列。
依照以下規格實作程式，並自行撰寫test code驗證：
```
publicint[]SortArray(int[] nums)
{
……
}
```

練習5:
給定一個非空的整數陣列nums，已知此陣列中只會有其中一個元素出現一次，其他每個元素必定會出現兩次。請用程式找出只出現一次的元素。

(範例1):
輸入陣列:nums = [2, 2, 1]
輸出整數: 1

(範例2):
輸入陣列:nums = [4, 1, 2, 1, 2]
輸出整數: 4

(範例3):
輸入陣列:nums = [1]
輸出整數: 1

依照以下規格實作程式，並自行撰寫test code驗證：
```
publicintSingleNumber(int[] nums)
{
……
}
```