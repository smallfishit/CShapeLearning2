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
    public class VolumnTest
    {
        /// <summary>
        /// 計算體積的共用程式
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <param name="dot">限制小數點位數</param>
        /// <param name="volumn">體積</param>
        private void GetCalaulateVolumn(float length, float width, float height, int dot, float volumn)
        {
            //建立物件
            Cube volumnCal = new Cube();
            //顯示結果
            float result = volumnCal.CalculateVolumn(length, width, height, dot);
            //驗證結果是否正確
            Assert.AreEqual(volumn, result);
        }

        /// <summary>
        /// 體積的測試
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <param name="dot">限制小數點位數</param>
        /// <param name="volumn">體積</param>
        [TestCase(8.5f, 12.5f, 10.5f, 1, 1115.625f)]
        [TestCase(7.3f, 9.2f, 19.7f, 1, 1323.052f)]
        [TestCase(5.3f, 12.4f, 13.6f, 1, 893.792f)]
        [TestCase(14.1f, 6.7f, 22.6f, 1, 2135.022f)]
        [Test]
        public void CalculateVolumn_InputDecimal_ReturnVolumn(float length, float width, float height, int dot, float volumn)
        {
            GetCalaulateVolumn(length, width, height, dot, volumn);
        }

        /// <summary>
        /// 例外的測試
        /// </summary>
        /// <param name="length">長</param>
        /// <param name="width">寬</param>
        /// <param name="height">高</param>
        /// <param name="dot">限制小數點位數</param>
        /// <param name="volumn">體積</param>
        /// <param name="message">顯示訊息</param>
        [TestCase(8.52f, 12.5f, 10.5f, 1, 1115.625f, "小數位數最多只能1位數")]
        [TestCase(7.3f, 9.23f, 19.7f, 1, 1323.052f, "小數位數最多只能1位數")]
        [TestCase(5.3f, 12.4f, 13.64f, 1, 893.792f, "小數位數最多只能1位數")]
        [TestCase(14.1f, 6.7f, 22.65f, 1, 2135.022f, "小數位數最多只能1位數")]
        [Test]
        public void CalculateVolumn_InputDecimal_ReturnVolumn(float length, float width, float height, int dot, float volumn, string message)
        {
            string m_result = "";
            try
            {
                GetCalaulateVolumn(length, width, height, dot, volumn);
            }
            catch (Exception ex)
            {
                m_result = ex.Message;
            }
            //驗證結果是否正確
            Assert.AreEqual(message, m_result);
        }
    }
}
