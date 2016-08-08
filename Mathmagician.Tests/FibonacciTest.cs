using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void FibonacciIsAnObject()
        {
            Fibonacci fibonacci = new Fibonacci();
            Assert.IsNotNull(fibonacci);

        }
        [TestMethod]
        public void FibonacciStartsWithZero()
        {
            int x = 0;
            int y = 1;
            Assert.IsTrue(x == 0);
        }
        [TestMethod]
        public void FibonacciResultisXplusY()
        {
            int x = 0;
            int y = 1;
            int z = x + y;
            Assert.IsTrue(z == x + y);
        }
        [TestMethod]
        public void FibonacciStartingIntsTakeNewValues()
        {
            int x = 0;
            int y = 1;
            int z = 0;
            for (int i = 0; i < 1; i++)
            {
                z = x + y;
                x = y;
                y = z;
            }
            int expectedX = 1;
            int expectedY = 1;
            Assert.AreEqual(expectedX, y);
            Assert.AreEqual(expectedY, y);
        }
        [TestMethod]
        public void FibonacciSequenceIsCorrectPartOne()
        {
            int x = 0;
            int y = 1;
            
            for (int i = 0; i < 3; i++)
            {
                int z = x + y;
                x = y;
                y = z;
            }
            int expectedX = 3;
            int expectedY = 5;
            int result = x+y; //should return 5;
            Assert.AreEqual(expectedX, y);
            Assert.AreEqual(expectedY, result);
        }
        [TestMethod]
        public void FibonacciSequenceIsCorrectPartTwo()
            //this test should result in the 10th number in sequence = 55
        {
            int x = 0;
            int y = 1;
            List<int> resultList = new List<int>();
            for (int i = 0; i <= 10; i++)
            {
                int z = x + y;
                x = y;
                y = z;
                resultList.Add(z);
            }
            int expectedResult = 55;
            int actual = resultList[8];
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void FibonacciSequenceIsCorrectPartThree()
            // now we will test up to 317811
        {
            int x = 0;
            int y = 1;
            List<int> resultList = new List<int>();
            for (int i = 0; i <= 30; i++)
            {
                int z = x + y;
                x = y;
                y = z;
                resultList.Add(z);
            }
            int expectedResult = 317811;
            int actual = resultList[26];
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
