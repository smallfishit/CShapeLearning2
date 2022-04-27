using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05
{
    public class NumberAnalysis
    {
        public int SingleNumber(int[] nums)
        {
            Dictionary<int, int> numList = new Dictionary<int, int>();
            for(int i=0;i<nums.Length;i++)
            {
                int num = nums[i];
                if(numList.ContainsKey(num))
                {
                    numList.Remove(num);
                }
                else
                {
                    numList.Add(num, num);
                }
            }
            if (numList.Count != 1)
                throw new Exception("輸入陣列錯誤");
            int number = 0;
            foreach(int num in numList.Keys)
            {
                number = num;
            }
            return number;
        }
    }
}
