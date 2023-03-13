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

                if ( Age >  18 )
                {
                    Console.WriteLine("PLease pay the fees");
                }

                else if (Age == 18)
                {
                    Console.WriteLine("You got a discount of 50% ");
                }

                else
                {
                    Console.WriteLine("People below 18 are not allowed");
                }

            }

        }

        public void switch_cond()
        {
            Console.WriteLine("Plesae enter a number for the week day from (1 to 7)");
              int day_number = Convert.ToInt32(Console.ReadLine());

            switch (day_number)
            {
                case 1: Console.WriteLine("This is Monday");
                    break;

                case 2: Console.WriteLine("This is Tuesday");
                    break;

                case 3:
                    Console.WriteLine("This is Wednesday");
                    break;

                case 4:
                    Console.WriteLine("This is Thursday");
                    break;

                case 5:
                    Console.WriteLine("This is Friday");
                    break;

                case 6:
                    Console.WriteLine("This is saturdat");
                    break;

                case 7:
                    Console.WriteLine("This is sunday");
                    break;

              
            }

        }
    }
}
