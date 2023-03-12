using OpenQA.Selenium.DevTools.V107.Debugger;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace KD_Testing
{
    class Conditional_statements
    {
        public void if_cond()
        {
            Console.WriteLine("Please enter the Age ");
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age > 18)
            { 
                Console.WriteLine("PLease pay the fees");

            }

        }

        

        public void if_else_cond()
        {           
            Console.WriteLine("Please enter the Age ");
         
            int Age = Convert.ToInt32(Console.ReadLine());
            if (Age > 18)
            {
                Console.WriteLine("PLease pay the fees");
            }
            else 
            {
                Console.WriteLine("People below 18 are not allowed");
            }

            
        }

        public void else_if_cond()
        {

            while (true)
            {
                Console.WriteLine("Please enter the Age ");
                string a = Console.ReadLine();
                int Age = Convert.ToInt32(a);

                if (Age >= 18)
                {
                    Console.WriteLine("PLease pay the fees");

                    if (Age > 50)
                    {
                        Console.WriteLine("You got a discount of 50% ");
                    }
                }

            }

        }

        public void switch_cond()
        { 

        }
    }
}
