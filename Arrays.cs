using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace KD_Testing
{
    class Arrays
    {
        

      

        public void single_d_Array()
        {

            int[] numbers = new int[4] { 1, 3, 4, 5 } ;


            foreach (int i in numbers) {

                Console.WriteLine(i);
            }

            for (int i =0; i <4; i ++ )
            {
                Console.WriteLine(numbers[i]);
            }



            string[] food = new string[3];
            food[0] = "Pizza";
            food[1] = "burger";
            food[2] = "dosa";

            foreach (string u in food)
            {
                Console.WriteLine(u);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(food[i]);
            }


        }
        public void multi_d_Array() 
        {

            int[,] numb = new int[2, 4] { { 1, 2, 3, 4 }, { 6, 7, 8, 9 } }; 
            
            
            string[,] food = new string[2, 3];
            food[0, 0] = "Pizza";
            food[0, 1] = "burger";
            food[0, 2] = "Noodles";

            food[1, 0] = "dosa";
            food[1, 1] = "Upma";
            food[1, 2] = "Fried Rice";



            int[,] numbers = new int[3, 2] { { 1, 2}, { 5, 6} , { 7,8} };

            foreach (string item in food)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < 2; i++) 
            {
                for (int j = 0; j < 3; j++)
                    Console.WriteLine(food[i,j]);
            } 
        }

        public void Jaged_array() 
        {
            int[][] num = new int[3][];

            num[0] =new int[] {1,2,3,4 };
            num[1] = new int[] {8,7 };
            num[2] = new int[] { 9, 10, 11 };

            foreach ( int[] a  in num ) 
            {
                foreach (int b in a)

                {
                    Console.WriteLine(b); 
                }
            }


            string[][] food = 
                { 
                new string[] { "Noodles", "Fried Rice", "Manchuria" }, 
                new string[] { "Rice", "Roti", "Bread" }
                };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.WriteLine(food[i][j]);  
            }

        }
    }
}
