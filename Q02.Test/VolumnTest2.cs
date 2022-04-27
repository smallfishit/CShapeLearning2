using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q02.Test
{
    /// <summary>體積測試</summary>
    [TestFixture]
    public class VolumnTest2
    {
        /// <summary>
        /// 體積的測試
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <param name="volumn">體積</param>
        [TestCase(8.5d, 12.5d, 10.5d, 1115.625d)]
        [TestCase(7.3d, 9.2d, 19.7d, 1323.052d)]
        [TestCase(5.3d, 12.4d, 13.6d, 893.792d)]
        [TestCase(14.1d, 6.7d, 22.6d, 2135.022d)]
        [Test]
        public void CalculateVolumn2_InputDecimal_ReturnVolumn(decimal length, decimal width, decimal height, decimal volumn)
        {
            //建立物件
            VolumnCalculator volumnCal = new VolumnCalculator();
            //顯示結果
            decimal result = volumnCal.CalculateVolumn2(length, width, height);
            //驗證結果是否正確
            Assert.AreEqual(volumn, result);
        }
    }
}
