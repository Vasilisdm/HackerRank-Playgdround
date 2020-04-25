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
            Node p = new Node(data);

            if (head == null)
            {
                head = p;
            }
            else if (head.next == null)
            {
                head.next = p;
            }
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
    }
}
