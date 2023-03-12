using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace KD_Testing
{
    class Arrays
    {
        public void single_d_Array()
        {
            string[] food = new string[3];
            food[0] = "Pizza";
            food[1] = "burger";
            food[2] = "dosa";

            int[] numbers = new int[4] { 1, 2, 3, 4, };

        }
        public void multi_d_Array() 
        {
            // 
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
