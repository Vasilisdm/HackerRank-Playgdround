using System;
namespace HackerRank_Playground.LinkedList
{
    public static class CustomLinkedList
    {
        public static void Display(Node head)
        {
            Node start = head;
            while (start!=null)
            {
                Console.WriteLine($"{start.data} ");
                start = start.next;
            }
        }

        public static Node insert(Node head, int data)
        {
            if (head==null)
            {
                return new Node(data);
            }
            else if (head.next ==null)
            {
                head.next = new Node(data);
            }
            else
            {
                insert(head.next, data);
            }

            return head;
        }
    }
}
