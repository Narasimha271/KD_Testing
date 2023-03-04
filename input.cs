using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace KD_Testing // project
{
    class input // class
    {
        //Syntax for Method:  scope_of_the_method    return_type    method_name()   {}
        
         long a = 1L; // variable  implcitily convert long in to int
        float b = 2f;// variable  implcitily convert float in to int



        public void variable_print() 
        {
            Console.WriteLine(2.4);
            Console.WriteLine("rakesh");
            Console.WriteLine(true);
            Console.WriteLine(5+"is my rank");
        }

        public void input_test()
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Yoo hu this is your name: " + name);
        }

        public void sadds() // method
        {
            //  1)console should display: please enter a value A. 2) read the value A. 
            // 3)console should display: please enter a value B 4) read the value B. 
            // 5) print that the addition of A + B= 

            Console.WriteLine("Please enter a value A");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a value B");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The addition of A + B = " + (A + B));


        }

        // Topics we learnt today: input variables, String concatinetion, Type Casting.


    }
}
