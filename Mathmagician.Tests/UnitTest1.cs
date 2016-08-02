using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mathmagician.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ICanBeNamedAnything()
        {
            //Arrange

            //Act

            //Assert
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestMTabTwice()
        {
            //Arrange
            //Act
            //Assert
            Assert.IsTrue(true);
            Assert.Fail();
        }
        
        public void ThisIsNotATest()
        {

        }
    }
}
