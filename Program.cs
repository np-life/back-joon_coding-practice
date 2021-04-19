using System;

namespace ConsoleApp2_YP
{
    class Program
    {
        static void Main(string[] args)
        {
            String N = Console.ReadLine();
            int n = Convert.ToInt32(N);
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
