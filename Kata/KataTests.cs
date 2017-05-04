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

            this.AssertUnionedList(new List<int>() { 1, 2 }, unionedList);
        }

        [TestMethod]
        public void Given_SingleElementArrays__1__1()
        {
            var listFirst = new List<int>() { 1 };
            var listSecond = new List<int>() { 1 };
            
            var unionedList = this.sandbox.UnionSortedLists(listFirst, listSecond);

            this.AssertUnionedList(new List<int>() { 1 }, unionedList);
        }

        [TestMethod]
        public void Given_MultipleElementArrays__1_2_4__0_3()
        {
            var listFirst = new List<int>() { 1, 2, 4 };
            var listSecond = new List<int>() { 0, 3 };
            
            var unionedList = this.sandbox.UnionSortedLists(listFirst, listSecond);

            this.AssertUnionedList(new List<int>() { 0, 1, 2, 3, 4 }, unionedList);
        }

        [TestMethod]
        public void Given_MultipleElementArrays__0_100__1_3_5_8_22()
        {
            var listFirst = new List<int>() { 0, 100 };
            var listSecond = new List<int>() { 1, 3, 5, 8, 22 };

            var unionedList = this.sandbox.UnionSortedLists(listFirst, listSecond);

            this.AssertUnionedList(new List<int>() { 0, 1, 3, 5, 8, 22, 100 }, unionedList);
        }

        [TestMethod]
        public void Given_MultipleElementArrays__2_5_44__1_2_5_22()
        {
            var listFirst = new List<int>() { 2, 5, 44 };
            var listSecond = new List<int>() { 1, 2, 5, 22 };

            var unionedList = this.sandbox.UnionSortedLists(listFirst, listSecond);

            this.AssertUnionedList(new List<int>() { 1, 2, 5, 22, 44 }, unionedList);
        }

        private void AssertUnionedList(List<int> expected, List<int> actual)
        {
            Assert.AreEqual(expected.Count, actual.Count);

            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
