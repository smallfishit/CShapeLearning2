using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q05.Test
{
    /// <summary>排序測試</summary>
    [TestFixture]
    public class NumberTest
    {
        /// <summary>排序測試資料</summary>
        private static NumberTestData[] _sortTestArray = new[]
        {
            new NumberTestData(new int[] { 2, 2, 1 }, 1),
            new NumberTestData(new int[] { 2, 3, 3, 1, 1 }, 2),
            new NumberTestData(new int[] { 4, 1, 2, 1, 2 }, 4),
            new NumberTestData(new int[] { 1 }, 1),
        };

        /// <summary>
        /// 排序的測試
        /// </summary>
        /// <param name="numberData">排序物件</param>
        [Test]
        public void ShowScoreResult_InputScore_ReturnOutOfRange([ValueSource("_sortTestArray")]NumberTestData numberData)
        {
            //建立物件
            NumberMethod analysis = new NumberMethod();
            //顯示結果
            int result = analysis.SingleNumber(numberData.inputArray);
            //驗證結果是否正確
            Assert.AreEqual(numberData.output, result);
        }
    }
}
