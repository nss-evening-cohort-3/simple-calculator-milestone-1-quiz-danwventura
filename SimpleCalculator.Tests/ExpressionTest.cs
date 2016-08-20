using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanExtractAllValues()
        {
            Expression exp = new Expression();
            exp.Parser("5 + 6");
           
            Assert.AreEqual(5 , exp.Integer1);
            Assert.AreEqual(6 , exp.Integer2);
            Assert.AreEqual("+" , exp.Expression_Operand);
                    
        }
    }
}
