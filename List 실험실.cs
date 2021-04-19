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
            List<int> myList_list = new List<int>();
            LinkedList<int> myList_linked = new LinkedList<int>(); // 주석
            ArrayList myList_array = new ArrayList(); // 주석

            int a = myList_list[0]; // 연속된 영역에 마치 리스트처럼 무한하게 데이터를 저장할수 있다. direct access.
            // int b = myList_linked[0]; // 마치 연속된 영역에 차곡차곡 무한히 데이터를 저장할수 있다. 하지만 다이렉트 엑세스는 불가능.
            int c = (int)myList_array[0]; // List와 유사하고 object로 박싱되서 처리하기때문에 다양한 타입을 동시에 처리할수있다. direct access.

            // List<int> 데이터 초기화.
            Console.WriteLine("List<int> 데이터 초기화.");
            for (int i = 0; i < 10; i++)
                myList_list.Add(10);
            Console.WriteLine("List<int> 모든 데이터 조회.");
            // List<int> 모든 데이터 조회하기.
            Writer_List(myList_list);


            // direct access 지원.
            Console.WriteLine("List<int> index 2 데이터 조회.");
            Console.WriteLine(myList_list[2]);
            Console.WriteLine("\n");

            // 데이터를 주고 위치를 삭제하기.
            Console.WriteLine("List<int> 정수2 에 해당되는 위치 삭제.");
            myList_list.Remove(2); // 데이터 2에 해당하는 위치 삭제.
            Writer_List(myList_list);

            // 인덱스를 주고 위치를 삭제하기.
            Console.WriteLine("List<int> 인덱스 2 위치 삭제.");
            myList_list.RemoveAt(2); // 데이터 2에 해당하는 위치 삭제.
            Writer_List(myList_list);

            // 인덱스를 주고 해당 위치에 데이터 추가하기.
            Console.WriteLine("List<int> 인덱스 2 위치 데이터 3 추가.");
            myList_list.Insert(2, 3); // 인덱스 2 위치에 데이터 3 추가.
            Writer_List(myList_list);

            // 인덱스를 주고 해당 위치에 데이터 추가하기.
            Console.WriteLine("List<int> 인덱스 2 위치 데이터 2 추가.");
            myList_list.Insert(2, 2); // 인덱스 2 위치에 데이터 2 추가.
            Writer_List(myList_list);

            // List<int> 에 새로운 데이터를 Push.
            Console.WriteLine("List<int> 데이터 10 Push.");
            myList_list.Add(10); // 데이터 10 Push.
            Writer_List(myList_list);

            // List<int> 데이터의 합 구하기.
            Console.WriteLine("List<int> 데이터 총합.");
            Console.WriteLine(myList_list.Sum());
            Writer_List(myList_list);

            // List<int> 내림차순으로 정렬하기.
            Console.WriteLine("List<int> 내림차순으로 정렬.");
            myList_list.Reverse();
            Writer_List(myList_list);

            // List<int> 오름차순으로 정렬하기.
            Console.WriteLine("List<int> 오름차순으로 정렬.");
            myList_list.Sort();
            Writer_List(myList_list);

            // 중복된 값 제거하기. (실험)
            Console.WriteLine("List<int> 중복된 값 제거하기. - list.Distinct() 메서드 활용.");
            var test_list = myList_list.Distinct(); // myList_list 를 복사해서 중복을 삭제한 다른 데이터의 시작 주소를 test_list가 받은것으로 추정.
            int sum = 0; 
            foreach (int i in test_list) // foreach 사용 예시. (int i in test_list 대신 var i in test_list도 사용하더라.)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
            sum = 0;
            Console.WriteLine(test_list.Sum()); // var 타입이지만 내부적으론 list 이므로 list에서 썼던 메서드는 사용할수있는것으로 보인다.
            Writer_List(myList_list); // 따라서 기존의 원본은 데이터 변화없음.

            // 중복된 값을 제거하는 다른 방법. - Contains 메서드.
            Console.WriteLine("List<int> 중복된 값 제거하기. - Contains 메서드.");
            List<int> myList_list_cp = new List<int>();
            for (int i = 0; i < myList_list.Count; i++)
            {
                if(!myList_list_cp.Contains(myList_list[i]))
                    myList_list_cp.Add(myList_list[i]);
            }
            Console.WriteLine("원본 myList_list");
            Writer_List(myList_list);
            Console.WriteLine("사본 myList_list_cp");
            Writer_List(myList_list_cp);
            myList_list.Clear();
            Console.WriteLine("myList_list.Clear() 이후 원본 myList_list");
            Writer_List(myList_list); // 출력. 리스트 요소 없음. Count : 0.
        }
        static void Writer_List(List<int> myList) // 모든 데이터를 조회하고 데이터 개수를 출력합니다. 
        {
            Console.WriteLine("======");
            foreach (int i in myList)
                Console.WriteLine(i);
            Console.WriteLine("======");
            Console.WriteLine("요소 개수 : " + myList.Count + "\n");
        }
    }
}
