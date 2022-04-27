using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04
{
    /// <summary>陣列方法</summary>
    public class ArrayMethod
    {
        /// <summary>
        /// 幫陣列排序(氣泡排序法)
        /// </summary>
        /// <param name="nums">未排序陣列</param>
        /// <returns></returns>
        public int[] SortArray(int[] nums)
        {
            int[] arr = nums.ToArray();
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if (arr[i] > arr[j])
                        (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            return arr;
        }
    }
}
