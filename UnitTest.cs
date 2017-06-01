using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;

namespace Day1Homework
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void 驗證_三筆一組加總Cost是否相等()
        {
            var expected = new List<int> { 6, 15, 24, 21 };

            var target = new TestTarget();
            
            var actual = target.Sum(3, Field.Cost);
 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 驗證_四筆一組加總Revenue是否相等()
        {
            var expected = new List<int> { 50, 66, 60 };

            var target = new TestTarget();

            var actual = target.Sum(4, Field.Revenue);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
