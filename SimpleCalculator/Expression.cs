﻿using System;
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


            
            user_input = user_input.Replace(" ", ""); //Getting rid of empty spaces in user input
            string[] possible_operands = {"+","-", "*", "-", "%", "/"}; //establishing a string array of all possible operands
            string[] numbers_array = user_input.Split('+','-','%','*','/'); //splitting user input on operands to create array of just numbers
            Integer1 = int.Parse(numbers_array[0]); //setting Integer1 value to first value in numbers array
            Integer2 = int.Parse(numbers_array[1]); //setting Integer2 value to second value in numebrs array
            for (int i=0; i < possible_operands.Length; i++) //for loop runs through possible operands and assigns correct operand to Expression_operand
            {
                if (user_input.Contains(possible_operands[i])) // if statement to check which(if any) operands are in the user's input expression
                {
                    Expression_Operand = possible_operands[i]; //assigning correct operand that is contained in user's expression
                }
            }
            


        }

        
        
       
    }
}
