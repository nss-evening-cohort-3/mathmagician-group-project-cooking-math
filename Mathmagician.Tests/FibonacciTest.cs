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
            Fibonacci fibonacci = new Fibonacci(10);

            Assert.IsNotNull(fibonacci);
        }
        [TestMethod]
        public void FibonacciInheritsPropertiesFromInteger()
        {
            Fibonacci fibonacci = new Fibonacci(10);
            int expectedIntegerProperty = 10;
            int actualIntegerProperty = fibonacci.integer;

            Assert.AreEqual(expectedIntegerProperty, actualIntegerProperty);
        }
        [TestMethod]
        public void FibonacciMakeIntegerListReturnsList()
        {
            Fibonacci fibonacci = new Fibonacci(10);
            fibonacci.MakeListOfIntegers(fibonacci.integer);
            List<int> expectedListProperty = fibonacci.intList;

            Assert.IsInstanceOfType(expectedListProperty, typeof(List<int>));
        }
        [TestMethod]
        public void FibonacciListIsCorrectSequencePart1()
        {
            Fibonacci fibonacci = new Fibonacci(10);
            fibonacci.MakeListOfIntegers(10);
            int expectedFirstInteger = 1;
            int actualFirstInteger = fibonacci.intList[0];
            Assert.AreEqual(expectedFirstInteger, actualFirstInteger);

            int expeectedSecondInteger = 1;
            int actualSecondInteger = fibonacci.intList[1];
            Assert.AreEqual(expeectedSecondInteger, actualSecondInteger);

            int expectedTenthInteger = 55;
            int actualTenthInteger = fibonacci.intList[9];
            Assert.AreEqual(expectedTenthInteger, expectedTenthInteger);
        }
        [TestMethod]
        public void FibonacciExpectedResultsForFiveInts()
        {
            Fibonacci fibonacci = new Fibonacci(5);
            fibonacci.MakeListOfIntegers(5);
            List<int> expected = new List<int> { 0, 1, 1, 2, 3 };
            List<int> actual = fibonacci.intList;

            CollectionAssert.AreEquivalent(expected, actual);
        }

    }
}

