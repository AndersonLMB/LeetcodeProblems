using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddTwoNumbers;

namespace Tests
{
    [TestClass]
    public class AddTwoNumbersTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //[2,4,3]
            //[5,6,4]
            var result = AddTwoNumbers.Solution.AddTwoNumbers(
                    new ListNode(2)
                    {
                        next = new ListNode(4)
                        {
                            next = new ListNode(3)
                            {
                                next = null
                            }
                        }
                    },
                    new ListNode(5)
                    {
                        next = new ListNode(6)
                        {
                            next = new ListNode(4)
                            {
                                next = null
                            }
                        }
                    });

            Assert.AreEqual(result.val, 7);
            Assert.AreEqual(result.next.val, 0);
            Assert.AreEqual(result.next.next.val, 8);
            Assert.AreEqual(result.next.next.next, null);

        }
        [TestMethod]
        public void TestMethod2()
        {

            //[1]
            //[9,9]
            var result = AddTwoNumbers.Solution.AddTwoNumbers(
                    new ListNode(1)
                    {
                        next = null
                    },
                    new ListNode(9)
                    {
                        next = new ListNode(9)
                        {
                            next = null
                        }
                    });

            Assert.AreEqual(result.val, 0);
            Assert.AreEqual(result.next.val, 0);
            Assert.AreEqual(result.next.next.val,1);
            Assert.AreEqual(result.next.next.next, null);

        }
    }
}

