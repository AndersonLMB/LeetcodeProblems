using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using StringToInteger;

namespace Tests
{
    [TestClass]
    public class StringToIntegerTest
    {
        [TestMethod]
        public void MyTestMethod()
        {
            //            Input: "42"
            //Output: 42

            var result = StringToInteger.Solution.MyAtoi("42");
            var expected = 42;
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void MyTestMethod2()
        {
            //Input: "   -42"
            //Output: -42


            var result = StringToInteger.Solution.MyAtoi("   -42");
            var expected = -42;
            Assert.AreEqual(result, expected);
        }
        [TestMethod]
        public void MyTestMethod3()
        {
            //Input: "4193 with words"
            //Output: 4193


            var result = StringToInteger.Solution.MyAtoi("4193 with words");
            var expected = 4193;
            Assert.AreEqual(result, expected);
        }
    }
}
