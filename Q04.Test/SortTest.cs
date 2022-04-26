using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q04.Test
{
    /// <summary>排序測試</summary>
    [TestFixture]
    public class SortTest
    {
        /// <summary>排序測試資料</summary>
        private static SortTestData[] _sortTestArray = new[]
        {
            new SortTestData(new int[] { 3, 2, 1 }, new int[]{ 1,2,3}),
            new SortTestData(new int[] { 2, 3, 4, 1 }, new int[]{ 1,2,3,4}),
        };

        /// <summary>
        /// 排序的測試
        /// </summary>
        /// <param name="sortData">排序物件</param>
        [Test]
        public void ShowScoreResult_InputScore_ReturnOutOfRange([ValueSource("_sortTestArray")]SortTestData sortData)
        {
            //建立物件
            ArraySort sort = new ArraySort();
            //顯示結果
            int[] result = sort.SortArray(sortData.inputArray);
            //驗證結果是否正確
            Assert.AreEqual(sortData.outputArray, result);
        }
    }
}
