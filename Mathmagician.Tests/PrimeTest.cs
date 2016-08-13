using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class PrimeTest
    {
        [TestMethod]
        public void CanCreateAnInstanceOfPrime()
        {
            Prime prime = new Prime(5);
            Assert.IsNotNull(prime);
        }

        [TestMethod]
        public void PrimeClassReturnsAList()
        {
            Prime prime = new Prime(0);
            var primeList = prime.MakeListOfIntegers(0);
            Assert.IsInstanceOfType(primeList, typeof(List<int>));
        }

        [TestMethod]
        public void PrimeReturnsTheRightNumberOfElements()
        {
            Prime prime = new Prime(8);
            var primeList = prime.MakeListOfIntegers(8);
            Assert.AreEqual(8, primeList.Count);
        }

        [TestMethod]
        public void PrimeReturnsAListWithTheCorrectSequence()
        {
            Prime prime = new Prime(10);
            List<int> rightList = new List<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            var primeList = prime.MakeListOfIntegers(10);
            CollectionAssert.AreEqual(primeList, rightList);
        }
    }
}
