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

        public static Node RemoveDuplicates(Node head)
        {
            if (head == null)
            {
                return null;
            }

            Node currentHead = head;
            Node nextHead = head.next;

            while (nextHead != null)
            {
                if (nextHead.data != currentHead.data)
                {
                    currentHead.next = nextHead;
                    currentHead = nextHead;
                }

                nextHead = nextHead.next;
            }

            currentHead.next = null;

            return head;
        }

        public static Node Insert(Node head, int data)
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
