using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02
{
    /// <summary>立方體物件</summary>
    public class Cube
    {
        /// <summary>
        /// 計算體積
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <returns></returns>
        public float CalculateVolumn(float length, float width, float height, int dot)
        {
            int dotNumber = GetDotNumber(length);
            string error = $"小數位數最多只能{dot}位數";
            if (dotNumber > dot)
            {
                throw new Exception(error);
            }
            dotNumber = GetDotNumber(width);
            if (dotNumber > dot)
            {
                throw new Exception(error);
            }
            dotNumber = GetDotNumber(height);
            if (dotNumber > dot)
            {
                throw new Exception(error);
            }
            return (float)Math.Round(length * width * height, dot*3);
        }

        /// <summary>
        /// 取得小數位數
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private int GetDotNumber(float number)
        {
            int dot = 0;
            while(number != (int)number)
            {
                number *= 10;
                dot++;
            }
            return dot;
        }

        /// <summary>
        /// 計算體積
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <returns></returns>
        public decimal CalculateVolumn2(decimal length, decimal width, decimal height)
        {
            return length * width * height;
        }
    }
}
