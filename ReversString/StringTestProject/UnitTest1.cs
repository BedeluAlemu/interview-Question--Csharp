using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReversString;
using System.Text;
namespace StringTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             string st = "1-1Redmond";
             StringBuilder expected = new StringBuilder("dnomdeR-11");

            ReversStringText obj = new ReversStringText();
            StringBuilder result =  obj.ReverseMethod(st);

            Assert.IsTrue(expected.Equals(result));

        }
        [TestMethod]
        public void TestMethod2()
        {
            string st = "Redmond";
            StringBuilder expected = new StringBuilder("dnomdeR");

            ReversStringText obj = new ReversStringText();
            StringBuilder result = obj.ReverseMethod(st);

            Assert.IsTrue(expected.Equals(result));

        }
    }
}
