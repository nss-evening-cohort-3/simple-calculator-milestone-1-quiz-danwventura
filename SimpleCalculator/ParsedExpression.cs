using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class ParsedExpression       //helper class that sets parsed user number/operator to int/char variables
    {
        public int Integer1 { get; set; }       //variable to store first integer that user enters
        public int Integer2 { get; set; }       //variable to store second integer that user enters
        public char Operand { get; set; }       //variable to store operand that user enters (stores as a char)

       
        
    }
}
