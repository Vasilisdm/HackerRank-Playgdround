using System;
using HackerRank_Playground.BST;

namespace HackerRank_Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Node root = null;
            Console.WriteLine("Insert the number of tree nodes.");
            int T = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Start inserting tree nodes.");
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = BinaryTree.Insert(root, data);
            }
            int height = BinaryTree.GetHeight(root);
            Console.WriteLine($"The height of the Binary Tree is: {height}");
        }
    }
}
