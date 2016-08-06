using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class oddTest
    {
        [TestMethod]
        public void OddNumberIsAnObject()
        {
            Odd oddnumbers = new Odd();
            Assert.IsNotNull(oddnumbers);
        }
        [TestMethod]
        public void OddNumberMakeListReturnsTypeList()
        {
            Odd oddnumbers = new Odd();
            List<int> oddList = oddnumbers.MakeListOfIntegers(0);
            Assert.IsInstanceOfType(oddList, typeof(List<int>));
        }
        [TestMethod]
        public void OddStartingOddNumberIsNotEven()
        {
            int startingNumber = 1;
            
            Assert.IsFalse(startingNumber % 2 == 0);
        }
        [TestMethod]
        public void OddStartingOddNumberIsOdd()
        {
            int startingNumber = 1;
            Assert.IsTrue(startingNumber % 2 == 1);
        }

        [TestMethod]
        public void OddSequenceIsEveryOtherNumber()
        {
            int a = 1;
            int b = 2;
            int expected = 3;
            int actual = a + b;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OddIntegerIsNotAString()
        {
            int a = 1;
            string b = "2";
            string actual = a + b;
            int expected = 3;
            Assert.AreNotEqual(expected, actual);
        }
        [TestMethod]
        public void OddListProvidesCorrectNumberofOddNumbers()
        {
            int desiredNumberofOddNumbers = 10;
            Odd odd = new Odd();
            List<int> iwanttenoddnumbers = odd.MakeListOfIntegers(desiredNumberofOddNumbers);
            Assert.AreEqual(desiredNumberofOddNumbers, iwanttenoddnumbers.Count);
        }
    }
}

//even number
//odd number
//string
//list
//parameter is integer

