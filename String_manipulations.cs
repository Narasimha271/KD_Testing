using OpenQA.Selenium.DevTools.V107.Network;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace KD_Testing
{
    class String_manipulations
    {
        string First_Name = "Rakesh";
        string Second_Name = "Tumula";
        int Age = 27;
        int account_number = 567483;
        
        public void String_concatenation()
        {
       
            Console.WriteLine(First_Name + "  "+ Second_Name);
            Console.WriteLine("My First name is: " + First_Name + " Second name is: " + Second_Name + "  My age is: "+ 27 );
            

        }

        public void String_interpolation()
        {
            Console.WriteLine($"My First name is: {First_Name}  Second name is:{Second_Name}   My age is:{Age}");
            Console.WriteLine();
        }
    }
}
