using System;
using System.Collections.Generic;
using System.Text;

namespace KD_Testing
{
    class Maths
    {

    

        public void add()  //scope_of_the_method return_type    method_name() { }   
        {  
            Console.WriteLine("please enter a values to add");
            string a = Console.ReadLine();
            int c = Convert.ToInt32(a);
            Console.WriteLine("please enter second values to add");
            string b = Console.ReadLine();
            int d = Convert.ToInt32(b);
            Console.WriteLine(c + d);
        }

   
        public void sub()
        {

        Console.WriteLine("please enter a values to subraction");
        string a = Console.ReadLine();
        int c = Convert.ToInt32(a);
            Console.WriteLine("please enter a second values to subraction");
        string b = Console.ReadLine();
        int d = Convert.ToInt32(b);
        Console.WriteLine(c - d);
        }

        public void div()
        {

    Console.WriteLine("please enter a values to divide");
    string a = Console.ReadLine();
    int c = Convert.ToInt32(a);
            Console.WriteLine("please enter a second values to divide");
            string b = Console.ReadLine();
    int d = Convert.ToInt32(b);
    Console.WriteLine(c / d);
        }

        static void Main(string[] args)
        {   
            // class_name obj_name = new class_name();
           input kittu = new input();
            // object_name.method_name();
            kittu.sadds();
        }




    }

      
      

    
}
