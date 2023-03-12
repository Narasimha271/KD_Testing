using System;
using System.Collections.Generic;
using System.Text;

namespace KD_Testing
{
    class operations
    {
        public void Multiplication_table()
        {
            Console.WriteLine("Please input a number:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication table of the given number is = " );
            Console.WriteLine(A +"X 1 = "+ A * 1);
            Console.WriteLine(A + "X 2 = " + A * 2);
            Console.WriteLine(A + "X 3 = " + A * 3);
            Console.WriteLine(A + "X 4 = " + A * 4);
            Console.WriteLine(A + "X 5 = " + A * 5);
            Console.WriteLine(A + "X 6 = " + A * 6);
            Console.WriteLine(A + "X 7 = " + A * 7);
            Console.WriteLine(A + "X 8 = " + A * 8);
            Console.WriteLine(A + "X 9 = " + A * 9);
            Console.WriteLine(A + "X 10 = " + A * 10);

        }
    }
}
