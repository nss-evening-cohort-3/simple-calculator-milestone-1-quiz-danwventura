using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace SimpleCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanExtractAllValues()
        {
            Expression exp = new Expression();
            ParsedExpression expValues = exp.Parser("5 + 6");
           
            Assert.AreEqual(5 , expValues.Integer1);
            Assert.AreEqual(6 , expValues.Integer2);
            Assert.AreEqual('+' , expValues.Operand);
                    
        }

        [TestMethod]
        public void CanExtractPlusOperandWithSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5 + 6");

            Assert.AreEqual('+', result.Operand);
        }

        [TestMethod]
        public void CanExtractMinusOperandWithSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5 - 6");

            Assert.AreEqual('-', result.Operand);
        }

        [TestMethod]
        public void CanExtractTimesOperandWithSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5 * 6");

            Assert.AreEqual('*', result.Operand);
        }

        [TestMethod]
        public void CanExtractDivisionOperandWithSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5 / 6");

            Assert.AreEqual('/', result.Operand);

        }

        [TestMethod]
        public void CanExtractModulusOperandWithSpaces()
        {

            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5 % 6");

            Assert.AreEqual('%', result.Operand);

        }

        [TestMethod]
        public void CanExtractPlusOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5+6");

            Assert.AreEqual('+', result.Operand);
        }

        [TestMethod]
        public void CanExtractMinusOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5-6");

            Assert.AreEqual('-', result.Operand);
        }

        [TestMethod]
        public void CanExtractTimesOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5*6");

            Assert.AreEqual('*', result.Operand);
        }

        [TestMethod]
        public void CanExtractDivisionOperandWithoutSpaces()
        {
            Expression exp = new Expression();
            ParsedExpression result = exp.Parser("5/6");

            Assert.AreEqual('/', result.Operand);

        }

        [TestMethod]
        public void CanExtractModulusOperandWithoutSpaces()
        {

            Expression exp = new Expression();
             ParsedExpression result = exp.Parser("5%6");

            Assert.AreEqual('%', result.Operand);

        }

        [TestMethod]
        public void RegexMatchWorking()
        {

            Regex testRegex = new Regex(@"[0-9]\s*[\+\-\*\%\/]\s*[0-9]");
            Expression exp = new Expression();
            string testExpression = "9 + 1";
            Match tester = testRegex.Match(testExpression);
            Assert.IsTrue(tester.Success);
            
            

            
        }



    }
}
