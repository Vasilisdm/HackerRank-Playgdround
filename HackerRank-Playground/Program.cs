using System;
using HackerRank_Playground.LinkedList;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Node head = null;

            Console.WriteLine("Insert the number of list's elements:");
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = CustomLinkedList.insert(head, data);
            }

            Console.WriteLine($"Linked List's nodes: ");
            CustomLinkedList.Display(head);
        }
    }
}
