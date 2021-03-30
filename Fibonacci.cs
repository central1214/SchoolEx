using System;

namespace Fibonacci
{
    class Program
    {
        class Fibonacci
        {
            public void Fibo1(int num)
            {
                long x = 1, y = 0;
                long fibonacci = 0;


                for (int i = 0; i < num; i++)
                {
                    y = x;
                    x = fibonacci;
                    fibonacci = x + y;
                    Console.WriteLine(i + 1 + "번째 Fibonacci 수열은 :" + fibonacci);
                }

            }
            public long Fibo2(int num)
            {
                if (num == 0) { return 0; }
                if (num == 1) { return 1; }
                return Fibo2(num - 1) + Fibo2(num - 2);
            }
            // private static Dictionary<int, long> memo = new Dictionary<int, long>();

            public long Fibo3(int num)
            {
                long[] fibo = new long[100];
                fibo[0] = 0;
                fibo[1] = 1;
                int i;

                for (i = 0; i < num; i++)
                {
                    fibo[i + 2] = fibo[i + 1] + fibo[i];
                }
                return fibo[i];
            }
        }



        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            int num = int.Parse(Console.ReadLine());
            fibo.Fibo1(num);
            //Console.WriteLine(fibo.Fibo2(60));
            Console.WriteLine(fibo.Fibo3(40));
        }
    }
}
