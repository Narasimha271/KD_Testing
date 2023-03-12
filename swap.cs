using System;
using System.Collections.Generic;
using System.Text;

namespace KD_Testing
{
    class swap
    {
        public void Shi() 
        {
            Console.WriteLine("Please Input First number:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Input Second number:");
            int B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" The numbers after Swapping");
            Console.WriteLine("The First number is:" + B);
            Console.WriteLine("The Second number is:"+ A);
        }
    }
}
