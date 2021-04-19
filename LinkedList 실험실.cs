using System;
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
            // LinkedList<string> 초기화.
            LinkedList<string> list = new LinkedList<string>();
            // LinkedList<string>.AddLast("") 노드 추가.
            list.AddLast("Apple");
            list.AddLast("Banana");
            list.AddLast("Lemon");

            // LinkedList<string> 내에서 "Banana" 라는 데이터를 가진 node를 찾아가지고 LinkedListNode 에 그 위치를 전달해주는듯 하죠? 
            LinkedListNode<string> node = list.Find("Banana");
            // 게다가 또 새로운 노드 객체를 만들어서 "Grape" 데이터로 초기화하고 LinkedList<string>에 추가 할것으로 보이죠?
            LinkedListNode<string> newNode = new LinkedListNode<string>("Grape");

            // 새 Grape 노드를 Banana 노드 뒤에 추가
            // 여기서 알 수 있는건, 노드를 추가하기위해선 LinkedListNode<string> 가 필수적이고 객체가 생성되고 변수는 그 주소를 포함하고있습니다.
            list.AddAfter(node, newNode);

            // 리스트 출력
            list.ToList<string>().ForEach(p => Console.WriteLine(p));

            // Enumerator 리스트 출력
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedList linkedList = new linkedList();
            linkedList.add(1);
            linkedList.add(2);
            linkedList.add(3);
            linkedList.add(4);
            linkedList.add(5);

            linkedList.moveFirst();

            while (linkedList.cur != null)
            {
                Console.WriteLine(linkedList.cur.value);
                linkedList.next();
            }

            Console.ReadKey();

            linkedList.moveLast();

            while (linkedList.cur != null)
            {
                Console.WriteLine(linkedList.cur.value);
                linkedList.pre();
            }
            Console.ReadKey();
        }
    }

    class linkedList
    {
        private node last;
        private node first;
        public node cur;

        public linkedList()
        {
            this.first = null;
            this.last = null;
            this.cur = null;
        }

        public void add(int value)
        {
            node node = new node();
            node.preNode = this.last;
            node.value = value;
            node.nextNode = null;

            if (this.first == null)
            {
                this.first = node;
                this.cur = node;
            }

            if (this.last != null)
            {
                this.last.nextNode = node;
            }
            this.last = node;
        }

        public void remove()
        {
            if (this.cur == null)
            {
                return;
            }
            this.cur.preNode.nextNode = this.cur.nextNode;
            this.cur.nextNode.preNode = this.cur.preNode;
            this.cur = null;
        }

        public void next()
        {
            if (this.cur == null)
            {
                return;
            }
            this.cur = this.cur.nextNode;
        }

        public void pre()
        {
            if (this.cur == null)
            {
                return;
            }
            this.cur = this.cur.preNode;
        }

        public void moveFirst()
        {
            this.cur = this.first;
        }

        public void moveLast()
        {
            this.cur = this.last;
        }
    }

    class node
    {
        public int? value;
        public node preNode;
        public node nextNode;

        public node()
        {
            this.value = null;
            this.preNode = null;
            this.nextNode = null;
        }
    }
}
