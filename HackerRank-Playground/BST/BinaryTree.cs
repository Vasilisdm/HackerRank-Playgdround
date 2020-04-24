using System;
namespace HackerRank_Playground.BST
{
    public static class BinaryTree
    {
        static Queue<Node> nodeQueue = new Queue<Node>();
        
        public static int GetHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }
            return 1 + (Math.Max(GetHeight(root.left), GetHeight(root.right)));
        }
        
        public static void LevelOrder(Node root)
        {
            nodeQueue.Enqueue(root);
            while (nodeQueue.Count > 0)
            {
                var node = nodeQueue.Dequeue();
                Console.Write(node.data + " ");

                if (node.left != null)
                {
                    nodeQueue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    nodeQueue.Enqueue(node.right);
                }
            }
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
