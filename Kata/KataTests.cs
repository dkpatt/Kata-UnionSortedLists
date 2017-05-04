using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata
{
    [TestClass]
    public class KataTests
    {
        private Sandbox sandbox;

        [TestInitialize]
        public void Setup()
        {
            sandbox = new Sandbox();
        }

        [TestMethod]
        public void Given_SingleElementArrays__1__2()
        {
            var listFirst = new List<int>() { 1 };
            var listSecond = new List<int>() { 2 };
            
            var unionedList = this.sandbox.UnionSortedLists(listFirst, listSecond);

            Assert.AreEqual(unionedList.Count, 2);
            Assert.AreEqual(1, unionedList[0]);
            Assert.AreEqual(2, unionedList[1]);
        }

        [TestMethod]
        public void Given_SingleElementArrays__1__1()
        {
            var listFirst = new List<int>() { 1 };
            var listSecond = new List<int>() { 1 };
            
            var unionedList = this.sandbox.UnionSortedLists(listFirst, listSecond);

            Assert.AreEqual(unionedList.Count, 1);
            Assert.AreEqual(1, unionedList[0]);
        }

        [TestMethod]
        public void Given_MultipleElementArrays__1_2_4__0_3()
        {
            var listFirst = new List<int>() { 1, 2, 4 };
            var listSecond = new List<int>() { 0, 3 };
            
            var unionedList = this.sandbox.UnionSortedLists(listFirst, listSecond);

            Assert.AreEqual(unionedList.Count, 5);
            Assert.AreEqual(0, unionedList[0]);
            Assert.AreEqual(1, unionedList[1]);
            Assert.AreEqual(2, unionedList[2]);
            Assert.AreEqual(3, unionedList[3]);
            Assert.AreEqual(4, unionedList[4]);
        }
    }
}
