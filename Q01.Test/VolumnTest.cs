using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q01.Test
{
    /// <summary>體積測試</summary>
    [TestFixture]
    public class VolumnTest
    {
        /// <summary>
        /// 體積的測試
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <param name="volumn">體積</param>
        [TestCase(8, 10, 12, 960)]
        [TestCase(7, 9, 20, 1260)]
        [TestCase(5, 12, 13, 780)]
        [TestCase(14, 6, 22, 1848)]
        [Test]
        public void ShowScoreResult_InputScore_ReturnOutOfRange(int length, int width, int height, int volumn)
        {
            //建立物件
            VolumnCalculator volumnCal = new VolumnCalculator();
            //顯示結果
            int result = volumnCal.CalculateVolumn(length, width, height);
            //驗證結果是否正確
            Assert.AreEqual(volumn, result);
        }
    }
}
