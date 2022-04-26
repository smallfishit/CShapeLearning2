using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    /// <summary>體積計算物件</summary>
    public class VolumnCalculator
    {
        /// <summary>
        /// 計算體積
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <returns></returns>
        public decimal CalculateVolumn(decimal length, decimal width, decimal height)
        {
            return length * width * height;
        }
    }
}
