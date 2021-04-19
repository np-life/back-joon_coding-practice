using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_YP
{
    class Program
    {
        static public void Main(String[] args)
        {
            String input1 = Console.ReadLine();
            String input2 = Console.ReadLine();
            String input3 = Console.ReadLine();
            int A = Convert.ToInt32(input1);
            int B = Convert.ToInt32(input2);
            int C = Convert.ToInt32(input3);
            int Multi = A * B * C;
            String Multi_Array = Multi.ToString();

            int how_many;
            char[] sample = new char[] { '0','1','2','3','4','5','6','7','8','9'};
            for (int i = 0; i < 10; i++) 
            {
                how_many = 0;
                for (int j = 0; j < Multi_Array.Length; j++)
                {
                    if (Multi_Array[j] == sample[i])
                        how_many++;
                }
                Console.WriteLine(how_many);
            }
        }
    }
}
