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
            String input = Console.ReadLine(); // 0에서 99사이의 숫자를 입력을 받고 (저장은 읽기만 가능한 String) - 다신 안쓸 input.
            int start_number = Convert.ToInt32(input);

            int[] Goal_number = new int[2];
            int[] Test_number = new int[2];
            int tmp;
            int count = 0;
            if(start_number < 10)
            {
                Goal_number[0] = 0;
                Goal_number[1] = start_number;
            }
            else
            {
                Goal_number[0] = start_number / 10;
                Goal_number[1] = start_number % 10;
            }


            // 최초의 Test_number[] 초기화
            for (int i = 0; i < Goal_number.Length; i++)
                Test_number[i] = Goal_number[i];
            // Loop : Goal_number[]과 Test_number[]이 같은 배열(숫자)이 아니면.
            while(true)
            {
                count++;
                tmp = Test_number[1];
                if (Test_number.Sum() > 9)
                {
                    Test_number[1] = Test_number.Sum() % 10;
                }
                else
                    Test_number[1] = Test_number.Sum();
                Test_number[0] = tmp;

                if (Goal_number[0] == Test_number[0] && Goal_number[1] == Test_number[1])
                    break;
            }
            Console.WriteLine(count);
        }
    }
}
