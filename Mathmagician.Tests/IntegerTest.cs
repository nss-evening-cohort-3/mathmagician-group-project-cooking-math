using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTest
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {
            Integer my_int = new Integer(5);

            Assert.IsNotNull(my_int);
        }
        [TestMethod]
        public void IntegerModifyProperty()
        {
            Integer my_int = new Integer(1);
            int x = 1;
            my_int.integer = 5;
            int expected = 5;

            Assert.IsFalse(x == my_int.integer);
            Assert.AreEqual(expected, my_int.integer);
        }
        [TestMethod]
        public void IntegerGetterAcceptsIntAsArgument()
        {
            Integer integer = new Integer(5);
            int expectedInteger = 5;
            int actualInteger = integer.integer;

            Assert.AreEqual(expectedInteger, actualInteger);
        }
        [TestMethod]
        public void IntegerStartingValueIs1()
        {
            Integer integer = new Integer(5);
            int expectedStartingNumber = 1;
            integer.MakeListOfIntegers(integer.integer);
            int actualStartingNumber = integer.intList[0];

            Assert.AreEqual(1, expectedStartingNumber);
        }
        [TestMethod]
        public void IntegersAreSequential()
        {
            Integer integer = new Integer(3);
            integer.MakeListOfIntegers(integer.integer); 
            List<int> expected = new List<int> { 1, 2, 3 };
            List<int> actual = integer.intList;

            CollectionAssert.AreEquivalent(expected, actual);
        }
        [TestMethod]
        public void IntegerReturnsList()
        {
            Integer my_int = new Integer(5);
            List<int> expectedType = my_int.intList;

            Assert.IsInstanceOfType(expectedType, typeof(List<int>));
        }
        [TestMethod]
        public void IntegersListAddsCorrectCount()
        {
            //Arrange
            Integer intTest = new Integer(10);
            int expectedCount = 10;
            List<int> testlist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.AreEqual(testlist.Count, expectedCount);
        }
        [TestMethod]
        public void IntegersAreCorrectSequence()
        {
            Integer intTest = new Integer(10);
            intTest.MakeListOfIntegers(intTest.integer);
            List<int> testListGood = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> testListBad = new List<int> { 1, 3, 4, 8, 10, 7, 2, 5, 9, 6 };
            List<int> actualSequence = intTest.intList;

            CollectionAssert.AreEquivalent(actualSequence, testListGood);
            CollectionAssert.AreNotEqual(actualSequence, testListBad);
        }
             

    }
}