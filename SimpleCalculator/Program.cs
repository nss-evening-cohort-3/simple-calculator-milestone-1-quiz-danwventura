using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
                     

            Console.Write("[x]>");
            string user_entry = Console.ReadLine().ToLower();
             while (user_entry != "quit")  //        while loop for operation counter that will only stop if entry == quit
            {
                int counter = 0;           //        initializing counter which will be displayed/updated after every expression is evaulated
                Console.Write($"[{counter}]");
                

                    counter++;              //       incrementing counter by one after every expression
            }



        }

    }
}
