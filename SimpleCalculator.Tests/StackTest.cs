using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void EnsureCanCreateInstanceOfStack()
        {
            Stack this_stack = new Stack();
            Assert.IsNotNull(this_stack);
        }


    }
}
