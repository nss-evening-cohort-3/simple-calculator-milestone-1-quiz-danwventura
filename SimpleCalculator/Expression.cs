using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
   public class Expression
    {
        public int Integer1 { get; set; }
        public int Integer2 { get; set; }
        public string Expression_Operand { get; set; }
        public bool Had_Error { get; set; }

        public void Parser(string user_input)
        {
            user_input = user_input.Replace(" ", "");
            string[] possible_operands = {"+","-", "*", "-", "%"};
            string[] numbers_array = user_input.Split('+','-','%','*','/');
            Integer1 = int.Parse(numbers_array[0]);
            Integer2 = int.Parse(numbers_array[1]);
            for (int i=0; i < possible_operands.Length; i++)
            {
                if (user_input.Contains(possible_operands[i]))
                {
                    Expression_Operand = possible_operands[i];
                }
            }
            

        }

        
        
       
    }
}
