using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
   public class Calculate   //            Calculate class handles all calculations using private methods for
                            //             the actual math and a public method to call the correct computation depending on user's input
    {
        private int Add(int integer1, int integer2)
        {
            return integer1 + integer2;
        }

        private int Subtract(int integer1, int integer2)
        {
            return integer1 - integer2;
        }

        private int Multiply(int integer1, int integer2)
        {
            return integer1 * integer2;
        }

        private int Divide(int integer1, int integer2)
        {
            return integer1 / integer2;
        
        }

        private int Modulus(int integer1, int integer2)
        {
            return integer1 % integer2;

        }

        public int Evaluate(ParsedExpression result)  //            Evaluate takes ParsedExpression as an argument and switches on
                                                      //            on the operand that the user enters
        {
            switch (result.Operand)
            {
                case '+':
                    return Add(result.Integer1, result.Integer2);

                case '-':
                    return Subtract(result.Integer1, result.Integer2);

                case '/':
                    return Divide(result.Integer1, result.Integer2);

                case '*':
                    return Multiply(result.Integer1, result.Integer2);

                case '%':
                    return Modulus(result.Integer1, result.Integer2);

                default:
                    return 0;                                           //          Must return an int, cannot return an error message
                                                                        //          as string because of methods type
                    

            }

           
        }
        
    }
}
