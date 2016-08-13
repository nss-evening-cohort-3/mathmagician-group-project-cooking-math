using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class EvenTest
    {
        // can make instance of class
        [TestMethod]
        public void CanMakeInstanceOfEven()
        {
            Even myNewEven = new Even(4);
            Assert.IsNotNull(myNewEven);
        }
        
        // class returns a list even if 0 is passed in
        [TestMethod]
        public void EvenClassReturnsAList()
        {
            Even even = new Even(0);
            var coolList = even.MakeListOfIntegers(0);
            Assert.IsInstanceOfType(coolList, typeof(List<int>));
        }

        // class returns the correct .Count
        [TestMethod]
        public void EvenReturnsTheRightNumberOfElements()
        {
            Even even = new Even(8);
            var coolList = even.MakeListOfIntegers(8);
            Assert.AreEqual(8, coolList.Count);
        }
  
        // class returns a list with the correct sequence
        [TestMethod]
        public void EvenReturnsAListWithTheCorrectSequence()
        {
            Even even = new Even(4);
            List<int> rightList = new List<int> { 2, 4, 6, 8 };
            var coolList = even.MakeListOfIntegers(4);
            CollectionAssert.AreEqual(coolList, rightList);
        }



    }
}
