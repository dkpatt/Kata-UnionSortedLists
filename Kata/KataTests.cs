using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void Given_SingleElementArrays__1__2()
        {
            var listFirst = new List<int>() { 1 };
            var listSecond = new List<int>() { 2 };

            var sandbox = new Sandbox();
            var unionedList = sandbox.UnionSortedLists(listFirst, listSecond);

            Assert.AreEqual(unionedList.Count, 2);
            Assert.AreEqual(1, unionedList[0]);
            Assert.AreEqual(2, unionedList[1]);
        }
    }
}
