using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Day1Homework
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void 驗證_三筆一組加總Cost是否相等()
        {
            var expected = new int[] { 6, 15, 24, 21 };

            var stubDataSource = Substitute.For<IDataSource<int>>();
            stubDataSource.GetSum(3).Returns(new int[]{ 6, 15, 24, 21 });

            var actual = stubDataSource.GetSum(3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 驗證_四筆一組加總Revenue是否相等()
        {
            var expected = new int[] { 55, 66, 60 };

            var stubDataSource = Substitute.For<IDataSource<int>>();
            stubDataSource.GetSum(4).Returns(new int[] { 55, 66, 60 });

            var actual = stubDataSource.GetSum(4);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
