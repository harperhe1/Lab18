using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class LinkedListArray
    {
        private string[] items = new string[100];
        private int Count = 0;

        public int Length()
        {
            return Count;
        }
        public bool Insert(string newItem)
        {
            if (Count == items.Length)
            {
                return false;
            }
            items[Count] = newItem;
            Count++;
            return true;
        }
        public bool IsFull()
        {
            if (Count == items.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            return false;
        }
        public void PrintList()
        {
            int counter = 0;
            Console.Write("Start of list ->    ");
            while (counter < Count)
            {
                Console.Write(items[counter]);
                Console.Write(" -> ");
                counter++;
            }
            Console.WriteLine("end of list");
        }
        public bool RemoveAt(int index)
        {
            if (index > Count || index < 0)
            {
                return false;
            }
            return true;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {
            /*LinkedListArray myList = new LinkedListArray();
            Console.WriteLine("my list's length is " + myList.Length());
            Console.WriteLine("is empty = " + myList.IsEmpty());
            Console.WriteLine("is full = " + myList.IsFull());


            myList.Insert("Dan");
            myList.Insert("Jacky");
            myList.Insert("Mace");
            myList.Insert("Yolanda");
            myList.Insert("David");
            myList.Insert("daviD");

            myList.PrintList();

            Console.WriteLine("my list's length is " + myList.Length());
            Console.WriteLine("is empty = " + myList.IsEmpty());
            Console.WriteLine("is full = " + myList.IsFull());*/

            LinkedListNode myLists = new LinkedListNode();
            myLists.Add("Steve");
            myLists.Add("Mauricio");
            myLists.Add("Evan");
            myLists.Add("Dan");

            Console.WriteLine("my list's count is " + myLists.Count);
            myLists.PrintReverse();

            Console.ReadLine();
        }
    }
}
class Node
{
    public string Data
    {
        set; get;
    }
    public Node Next { set; get; }
    public Node Previous { set; get; }
}

class DoublyLinkedNode
{

}
class LinkedListNode
{
    public Node Head { set; get; }
    public Node Tail { set; get; }
    public int Count { set; get; }

    public void Add(string userInput)
    {
        Node newNode = new Node { Next = null, Data = userInput };
        if (Count == 0)
        {
            Head = newNode;
            Tail = newNode;
            Count++;
        }
        else
        {
            //change the previous reference in the new node
            newNode.Previous = Tail;
            //change the tail next reference
            Tail.Next = newNode;
            //change the tail
            Tail = newNode;
            Count++;
        }
    }
    public Node GetNode(int index)
    {
        int start = 0;
        Node temp = Head;   //mark the start of my search
        while (start != index)
        {
            start += 1;
            temp = temp.Next;
        }
        return temp;    //once found; return the node; else return null
    }
    public void PrintList()
    {
        for (int i = 0; i < Count; i++)
        {
            Console.WriteLine(GetNode(i).Data);
        }
    }
    public void PrintReverse()
    {
        //Program.Start();
        for (int i = Count; i > 0; i--)
        {
            Console.WriteLine(Tail.Data);
            Tail = Tail.Previous;
        }
    }
}
