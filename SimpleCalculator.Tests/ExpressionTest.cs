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

        [TestMethod]
        public void CanExtractPlusOperandWithSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5 + 6");

            Assert.AreEqual("+", exp.Expression_Operand);
        }

        [TestMethod]
        public void CanExtractMinusOperandWithSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5 - 6");

            Assert.AreEqual("-", exp.Expression_Operand);
        }

        [TestMethod]
        public void CanExtractTimesOperandWithSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5 * 6");

            Assert.AreEqual("*", exp.Expression_Operand);
        }

        [TestMethod]
        public void CanExtractDivisionOperandWithSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5 / 6");

            Assert.AreEqual("/", exp.Expression_Operand);

        }

        [TestMethod]
        public void CanExtractModulusOperandWithSpaces()
        {

            Expression exp = new Expression();
            exp.Parser("5 % 6");

            Assert.AreEqual("%", exp.Expression_Operand);

        }

        [TestMethod]
        public void CanExtractPlusOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5+6");

            Assert.AreEqual("+", exp.Expression_Operand);
        }

        [TestMethod]
        public void CanExtractMinusOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5-6");

            Assert.AreEqual("-", exp.Expression_Operand);
        }

        [TestMethod]
        public void CanExtractTimesOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5*6");

            Assert.AreEqual("*", exp.Expression_Operand);
        }

        [TestMethod]
        public void CanExtractDivisionOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            exp.Parser("5/6");

            Assert.AreEqual("/", exp.Expression_Operand);

        }

        [TestMethod]
        public void CanExtractModulusOperandWithoutSpaces()
        {

            Expression exp = new Expression();
            exp.Parser("5%6");

            Assert.AreEqual("%", exp.Expression_Operand);

        }



    }
}
