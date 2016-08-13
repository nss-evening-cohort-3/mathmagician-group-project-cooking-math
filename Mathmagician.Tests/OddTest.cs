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
            Odd oddnumbers = new Odd(5);
            Assert.IsNotNull(oddnumbers);
        }
        [TestMethod]
        public void OddHasProperties()
        {
            Odd odd = new Odd(10);
            int expectedIntProperty = odd.integer;
            List<int> expectedListProperty = odd.oddList;

            Assert.IsNotNull(expectedIntProperty);
            Assert.AreEqual(expectedIntProperty, 10);
            Assert.IsInstanceOfType(expectedListProperty, typeof(List<int>));
        }
        [TestMethod]
        public void OddNumberMakeListReturnsTypeList()
        {
            Odd oddnumbers = new Odd(5);
            List<int> oddList = oddnumbers.MakeListOfIntegers(0);
            Assert.IsInstanceOfType(oddList, typeof(List<int>));
        }
        [TestMethod]
        public void OddStartingOddNumberIsOdd()
        {
            Odd odd = new Odd(5);
            List<int> oddList = odd.MakeListOfIntegers(5);
            int expected = 1;
            int actual = oddList[0]; //1
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OddSequenceIsEveryOtherNumber()
        {
            Odd odd = new Odd(5);
            List<int> oddList = odd.MakeListOfIntegers(5);
            List<int> expectedSequenceList = new List<int> { 1, 3, 5, 7, 9 };
            CollectionAssert.AreEquivalent(expectedSequenceList, oddList);
        }
        [TestMethod]
        public void OddListProvidesCorrectNumberofOddNumbers()
        {
            int desiredNumberofOddNumbers = 10;
            Odd odd = new Odd(5);
            List<int> iwanttenoddnumbers = odd.MakeListOfIntegers(desiredNumberofOddNumbers);

            Assert.AreEqual(desiredNumberofOddNumbers, iwanttenoddnumbers.Count);
        }
        [TestMethod]
        public void OddMethodAcceptsLargeIntegerNumber()
        {
            Odd odd = new Odd(100000);
            List<int> oddList = odd.MakeListOfIntegers(odd.integer);

            Assert.IsNotNull(odd.oddList);
        }
        [TestMethod]
        public void OddMethodDoesNotAcceptLongInt()
        {
            //Odd odd = new Odd(10); // method does not accept long 64 bit integer
            //List<int> OddList = odd.MakeListOfIntegers(odd.integer);

            //Assert.IsNull(OddList);
        }
    }
}


