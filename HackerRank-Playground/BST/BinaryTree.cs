using System;
namespace HackerRank_Playground.BST
{
    public static class BinaryTree
    {
        public static int GetHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            return 1 + (Math.Max(GetHeight(root.left), GetHeight(root.right)));
        }

        public static Node Insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = Insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = Insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}
