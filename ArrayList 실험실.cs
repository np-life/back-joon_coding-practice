using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_YP
{
    class Class1
    {
        static public void Main(String[] args)
        {
            ArrayList myList = new ArrayList();
            Console.WriteLine("ArrayList 만들어 봤습니다.");

            // 데이터 추가.
            myList.Add(4.1);
            myList.Add('5');
            myList.Add(50);
            myList.Add('a');
            Console.WriteLine("ArrayList에 데이터 추가해 봤습니다.");
            Array_Writer(myList);
            Console.WriteLine("myList[1] : " + myList[1] + ",      myList[1] GetType() :" + myList[1].GetType()); // ArrayList에서 인덱스 1 데이터를 출력.
            Console.WriteLine("");

            // index=1 위치 삭제. (공간도 같이 삭제). - Count 감소.
            myList.RemoveAt(1);
            Console.WriteLine("ArrayList index 1 위치를 삭제했습니다.");
            Array_Writer(myList);
            Console.WriteLine("myList[1] : " + myList[1] + ",      myList[1] GetType() :" + myList[1].GetType()); // ArrayList에서 인덱스 1 데이터를 출력.
            Console.WriteLine("");

            Console.WriteLine(myList.Contains("abc")); // Contains 메서드는 값이 리스트 내에 있는지 bool 값을 반환한다.

            // 리스트 index=0에 "abc" 문자열 삽입.
            myList.Insert(0, "abc");
            Console.WriteLine("ArrayList index 0위치에 \"abc\" 요소를 추가했습니다.");
            Array_Writer(myList);
            Console.WriteLine("myList[1] : " + myList[1] + ",      myList[1] GetType() :" + myList[1].GetType()); // ArrayList에서 인덱스 1 데이터를 출력.
            Console.WriteLine("");

            Console.WriteLine(myList.Contains("abc")); // Contains 메서드는 값이 리스트 내에 있는지 bool 값을 반환한다.

            // ArrayList에 int[] 타입을 Add.
            int[] ary_i = new int[2];
            myList.Add(ary_i);
            Console.WriteLine(myList[myList.Count - 1].GetType()); // 제일 끝 리스트의 타입은?
            Array_Writer(myList);

            Console.WriteLine("ary_i 출력");
            foreach (int i in ary_i)
                Console.WriteLine(i);
            ary_i[0] = 100;
            int[] ary_i2 = (int[])myList[myList.Count - 1]; // 캐스팅이 필요한 부분.
            Console.WriteLine("수정된 ary_i를 aryi2로 출력 - 같은지 확인.");
            foreach (int i in ary_i2)
                Console.WriteLine(i);
        }

        static public void Array_Writer(ArrayList arr)
        {
            Console.WriteLine("==================");
            Console.WriteLine("myList.Count : " + arr.Count); // 리스트 요소 개수 출력.
            foreach (object ob in arr)
                Console.WriteLine(ob); // 리스트 모든요소 출력.
            Console.WriteLine("==================");
        }
    }
    class sample_people
    {
        public sample_people() { }

    }
}
