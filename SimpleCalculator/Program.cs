using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;        //        initializing counter which will be displayed/updated after every expression is evaluated
            Expression parser = new Expression();       //      initializing instance of Expression class
            Calculate calc = new Calculate();       //      initializing instance of Calculate class
            bool Continue = true;       //      initializing Continue bool 
            Regex expressionMatch = new Regex(@"[0-9]\s*[\+\-\*\%\/]\s*[0-9]");      //      creating instance of regex and passing in my regex rule
            Regex constantMatch = new Regex(@"([a-z])\s*\=\s*([0-9])*");            //      second regex to check for user entering new constant
            Regex mixedExpressionMatch = new Regex(@"([a-z])\s*([\-\+\*\/\%])\s*([0-9]*)");
            string constant_regex_pattern = @"([a-z,A-Z])\s*\=\s*([0-9])*";
            string mixed_expression_regex_pattern = @"([a-z])\s*([\-\+\*\/\%])\s*([0-9]*)";
            string user_entry = "ENTER EXPRESSION";       //      initializing string user_entry with value of a string which I will change in while loop
            Stack userStack = new Stack();
            



            while (Continue == true)  //        while loop for operation counter that will only stop if entry == quit
            {
                Console.Write($"[{counter}]>");        //      displaying counter each time loop runs
                user_entry = Console.ReadLine();        //      overwriting user_entry with expression that user enters
                if (user_entry.ToLower() == "quit")     //      if statement for user entering "quit"
                {
                    Continue = false;       //      setting Continue to false if user enter "Quit" || "quit" || "QUIT" else
                    break;      //      breaking out of if statement   ??????????????????????????? Am I breaking out of the if statement? Or the While Loop?
                }

                if (user_entry.ToLower() == "lastq")        //      if statement for user entering "lastq"
                {
                    string lastqExp = userStack.GetLastExpression();       //      setting lastqExp string to the last expression that is returned from GetLastExpression method 
                    Continue = true;        //      setting Continue to true so program will continue after previous expression is matched/printed to the terminal window
                    Console.WriteLine(lastqExp);      //      setting user_entry to last expression so it can be matched/printed again and continue to user's next expression
                    continue;
                }

                if (user_entry.ToLower() == "last")     //      if statement for user entering "last"
                {

                    int lastResult = userStack.GetLastAnswer();     //      setting lastResult to the last answer that is returned from GetLastAnswer method 
                    Continue = true;        //      setting Continue to true so program will continue after previous answer is converted to an expression and is matched/printed to the terminal window
                    Console.WriteLine(lastResult);       //      converting lastResult to string and concatenating to an expression with 0 so that it can be matched/printed to window
                    continue;
                }



                   //      setting last_expression variable in Stack class to current user_entry 
                Match user = expressionMatch.Match(user_entry);      //      matching user_entry against regex rule implemented on line 19 expressions to evaluate
                Match new_constant = constantMatch.Match(user_entry);          //      matching user_entry against second regex rule from line 20 for constants
                Match mixed_expression = mixedExpressionMatch.Match(user_entry);

                if (user.Success)       //      setting up if statement if user entered expression matches regex rule for an expression to be calculated
                {
                    userStack.SetLastExpression(user_entry);
                    var parsed = parser.Parser(user_entry);     //      setting parsed variable to ParsedExpression from Expression class     
                    int result = calc.Evaluate(parsed);     //      setting result to value returned from calculator class
                    userStack.SetLastAnswer(result);     //      setting last_answer variable in Stack class to current answer
                    Console.WriteLine(result);      //      displaying result
                    counter++;              //       incrementing counter by one after every expression
                }



                else if (new_constant.Success)          //      setting up if statement if second regex matches new constant
                {
                    MatchCollection constants = Regex.Matches(user_entry, constant_regex_pattern);

                    foreach (Match match in constants)
                    {
                        char new_user_constant_letter = char.Parse(match.Groups[1].Value.ToLower());
                        int new_user_constant_number = int.Parse(match.Groups[2].Value);

                        if (userStack.CheckIfConstantExistsInDictionary(new_user_constant_letter) == true)
                        {
                            Console.WriteLine("Constant already has a value. Select new letter for a new constant");
                        }
                        else
                        {
                            userStack.SetNewUserConstantInExpressionHolder(new_user_constant_letter, new_user_constant_number);
                        }
                    }
                }
                else if (mixed_expression.Success)
                {
                    MatchCollection mixed_expression_parts = Regex.Matches(user_entry, mixed_expression_regex_pattern);
                    foreach (Match part in mixed_expression_parts)
                    {
                        char already_stored_variable = char.Parse(part.Groups[1].Value);
                        char operand = char.Parse(part.Groups[2].Value);
                        int number_to_include_in_new_expression = int.Parse(part.Groups[3].Value);
                    }

                }



                else
                {
                    Console.WriteLine("Please enter two integers and one of the following operators --> (+, -, /, *, %)");
                }
                
            }



        }

    }
}
