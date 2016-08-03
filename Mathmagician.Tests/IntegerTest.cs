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
        public void IntegersAddToList()
        {
            //Arrange
            int NumOfIntegersToWrite = 10;
            Integer intTest = new Integer();
            List<int> testlist = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Act
            
            List<int> actual = intTest.Make_Integers(NumOfIntegersToWrite);
            //Assert
            Assert.AreEqual(actual.Count, NumOfIntegersToWrite);
        }

    }
}
