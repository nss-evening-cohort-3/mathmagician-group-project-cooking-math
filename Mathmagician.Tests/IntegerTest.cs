using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Mathmagician.Tests
{
    [TestClass]
    public class IntegerTest
    {
        [TestMethod]
        public void IntegerEnsureICanCreateAnInstance()
        {
            //Arrange

            //Act
            Integer my_int = new Integer(); //What I want to be able to do;

            //Assert
            Assert.IsNotNull(my_int);
        }
        [TestMethod]
        public void IntegerStartingValueIs1()
        {
            int startingNumber = 1;
            Assert.AreEqual(1, startingNumber);
        }
        [TestMethod]
        public void IntegersAreSequential()
        {
            int startingNumber = 1;
            int secondNumber = 2;
            int thirdNumber = 3;
            int difference = 1;
            Assert.IsTrue(thirdNumber - secondNumber == difference && secondNumber - startingNumber == difference);
            Assert.IsFalse(thirdNumber - secondNumber == 2);
        }
        [TestMethod]
        public void IntegerEnsureMethodIsList()
        {
            Integer my_int = new Integer();
            List<int> testlist = my_int.MakeListOfIntegers(1);

            Assert.IsInstanceOfType(testlist, typeof(List<int>));
        }
        [TestMethod]
        public void IntegersListAddsCorrectCount()
        {
            //Arrange
            int NumOfIntegersToWrite = 10;
            Integer intTest = new Integer();
            List<int> testlist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Act

            List<int> actual = intTest.MakeListOfIntegers(NumOfIntegersToWrite);
            //Assert
            Assert.AreEqual(testlist.Count, NumOfIntegersToWrite);
        }
        [TestMethod]
        public void IntegersAreCorrectSequence()
        {
            int numberOfIntegersToWrite = 9;
            Integer intTest = new Integer();
            List<int> testListGood = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> testListBad = new List<int> { 1, 3, 4, 8, 10, 7, 2, 5, 9, 6 };
            List<int> testListWrongCount = new List<int> { 1, 10 };

            List<int> actual = intTest.MakeListOfIntegers(numberOfIntegersToWrite);

            CollectionAssert.Equals(actual, testListGood);
            CollectionAssert.AreNotEqual(actual, testListBad);
            CollectionAssert.AreNotEquivalent(actual, testListWrongCount);
        }
        [TestMethod]
        public void IntegerTestLastInteger()
        {
            string lastNumber = "10";
            Integer intTest = new Integer();
            List<int> testList = intTest.MakeListOfIntegers(11);
            Assert.AreEqual(testList[9].ToString(), lastNumber);
        }

    }
}
