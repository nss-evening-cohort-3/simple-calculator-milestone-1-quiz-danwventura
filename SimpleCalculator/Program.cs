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
            Expression parser = new Expression();
            Calculate calc = new Calculate();
            
            Regex regexMatch = new Regex(@"[0-9]\s*[\+\-\*\%\/]\s*[0-9]");
            string user_entry = null;
            //Console.Write("[x]>");

            while (user_entry != "quit")  //        while loop for operation counter that will only stop if entry == quit
            {
                Console.Write($"[{counter}]>");
                user_entry = Console.ReadLine();
                Match user = regexMatch.Match(user_entry);

                if (user.Success)
                {
                    



                    
                    var parsed = parser.Parser(user_entry);
                    int result = calc.Evaluate(parsed);


                    Console.WriteLine(result);
                    counter++;              //       incrementing counter by one after every expression

                    //user_entry = Console.ReadLine().ToLower();


                }
                else
                {
                    Console.WriteLine("Please enter two integers and one of the following operators --> (+, -, /, *, %)");
                }
                
            }



        }

    }
}
