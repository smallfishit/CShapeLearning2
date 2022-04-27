using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
    /// <summary>數值方法</summary>
    public class NumberMethod
    {
        /// <summary>
        /// 取得落單的數字
        /// </summary>
        /// <param name="nums">數字陣列</param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> numList = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                int num = nums[i];
                if(numList.ContainsKey(num))
                {
                    //因為題目說只有一個落單, 其他數字都會是兩個, 所以再次出現的刪除
                    //改成另外一種方式
                    //numList.Remove(num);
                    //方法2，判斷落單的那個
                    numList[num]++;
                }
                else
                {
                    numList.Add(num, 1);
                }
            }
            /*//第一種方法目前不使用
            if (numList.Count != 1)
                throw new Exception("輸入陣列錯誤");
            int number = 0;
            foreach(int num in numList.Keys)
            {
                number = num;
            }
            //*/
            int number = numList.Where(x => x.Value == 1).First().Key;
            return number;
        }
    }
}
