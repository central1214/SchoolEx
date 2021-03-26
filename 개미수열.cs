using System;
using System.Collections.Generic;
using System.Threading;


namespace ConsoleApp0326
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] num1 = new int[1000];
            int[] num2 = new int[1000];

            num1[0] = 1;

            Console.WriteLine("몇열까지? :");
            int opt = int.Parse(Console.ReadLine());
            int count = 1;


            for (int i = 0; i < opt; i++)
            {
                int j = 0;
                int k = 0;
             
                while (num1[j] != 0)
                {
                    
                    if (num1[j] == num1[j + 1])
                    {
                        count++;
                    }
                    else
                    {
                        num2[k] = num1[j];
                        num2[k + 1] = count;
                        k += 2;
                        count = 1;
                    }
                    j++;
                }
                Array.Copy(num2, num1, num2.Length);
                Console.Write(i + "번째 수열 :");
                
                for (int l = 0; num1[l] != 0; l++)
                {
                    Console.Write(num1[l]);
                }
                Console.WriteLine();
            }

        }

    }
}

