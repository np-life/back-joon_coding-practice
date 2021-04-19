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
            String num_aec_s = Console.ReadLine();
            String number_s = Console.ReadLine();
            int num_aec = Convert.ToInt32(num_aec_s);
            int number = Convert.ToInt32(number_s);

            int[] pre_sum_array = new int[num_aec];
            int index = 0;
            int div = (int)Math.Pow(10, num_aec - 1);
            do
            {
                pre_sum_array[index] = number / div;
                number = number % div;
                div = div / 10;


                index++;
            }
            while (div >= 1);

            Console.WriteLine("=====");
            Console.WriteLine(pre_sum_array.Sum());
        }
    }
}
