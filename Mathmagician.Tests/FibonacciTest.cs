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
            var fibList = fibonacci.MakeListOfIntegers(10);
            Assert.IsInstanceOfType(fibList, typeof(List<int>));
        }
        [TestMethod]
        public void FibonacciListIsCorrectSequencePart1()
        {
            Fibonacci fibonacci = new Fibonacci(10);
            fibonacci.MakeListOfIntegers(10);
            int expectedFirstInteger = 1;
            int actualFirstInteger = fibonacci.fibList[0];
            Assert.AreEqual(expectedFirstInteger, actualFirstInteger);

            int expectedSecondInteger = 1;
            int actualSecondInteger = fibonacci.fibList[1];
            Assert.AreEqual(expectedSecondInteger, actualSecondInteger);

            int expectedTenthInteger = 55;
            int actualTenthInteger = fibonacci.fibList[9];
            Assert.AreEqual(expectedTenthInteger, actualTenthInteger);
        }
        [TestMethod]
        public void FibonacciExpectedResultsForFiveInts()
        {
            Fibonacci fibonacci = new Fibonacci(5);
            fibonacci.MakeListOfIntegers(5);
            List<int> expected = new List<int> { 1, 1, 2, 3, 5 };
            List<int> actual = fibonacci.fibList;

            CollectionAssert.AreEquivalent(expected, actual);
        }

    }
}

