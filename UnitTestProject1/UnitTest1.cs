using System;
using GitModisehTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var m=new Modi();
            Assert.AreEqual(m.calc(),3);
        }
    }
}
