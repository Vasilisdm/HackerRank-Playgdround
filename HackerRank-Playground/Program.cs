using System;
using HackerRank_Playground.LinkedList;
using Node = HackerRank_Playground.LinkedList.Node;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = CustomLinkedList.Insert(head, data);
            }

            head = CustomLinkedList.RemoveDuplicates(head);
            CustomLinkedList.Display(head);
        }
    }
}
