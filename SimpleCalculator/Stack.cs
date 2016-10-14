using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class Stack
    {

        Dictionary<string, int> expressionHolder = new Dictionary<string, int>();       //      initializing new dictionary which will take a string as a key and an int as a value from the user so constants can be set
        string user_variable { get; set; }        //      initializing a char that will be set with user's choice of a single letter to represent a variable
        int user_number { get; set; }       //      initializing an int that will be set with user's choice of a number that is the value that corresponds to the char variable established above
        string last_expression { get; set; }        //      initializing a string that will hold the previous expression that the user entered 
        int last_answer { get; set; }       //      initializing an int that will be the last answer generated from the last expression the user entered

        public void SetLastExpression(string user_expression)            //     setter for last expression the user entered
        {
            this.last_expression = user_expression;             //      setting last expression property equal to the expression the user entered
        }

        public void SetLastAnswer(int result)           //      setting last answer that was calculated from last user entered expression
        {
            this.last_answer = result;          //      setting last answer property equal to the result from calculating last user_expression input
        }

        public string GetLastExpression()           //      getter for last_expression
        {
            
            return last_expression;         //      returning last_expression
        }

        public int GetLastAnswer()          //      getter for last_answer
        {
            
            return last_answer;         //      returning last_answer
        }

        public void SetNewUserConstantInExpressionHolder(string new_user_constant_letter, int new_user_constant_number)
        {

            expressionHolder.Add(new_user_constant_letter, new_user_constant_number);
        }

        public bool CheckIfConstantExistsInDictionary(string new_user_constant_letter)
        {

            if (expressionHolder.ContainsKey(new_user_constant_letter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetInputConstantsValue(string user_constant_letter_input)
        {
            

            if (expressionHolder.ContainsKey(user_constant_letter_input))
            {
               int UsersConstantValue = expressionHolder[user_constant_letter_input];

                return UsersConstantValue;
            }
            return 0;
        }



    }

}

