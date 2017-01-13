using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 using System.Diagnostics;

 namespace BinarySearchTree
 {
     class Node
     {
         public int value;
         public Node left;
         public Node right;
     }

     class Tree
     {

        void printLeftBoundary(Node root)
        {

            if (root == null) return;
            if (root.left != null)
            {
                Console.WriteLine("{0} ", root.value);
                printLeftBoundary(root.left);
            }
            else if (root.right != null)
            {
                Console.WriteLine("{0} ", root.value);
                printLeftBoundary(root.right);
            }
        }

        void printLeafBoundary(Node root)
        {

            if (root != null)
            {

                printLeafBoundary(root.left);

                if (root.left == null && root.right == null)
                    Console.WriteLine("{0} ", root.value);

                printLeafBoundary(root.right);
            }
        }

        void printRightBoundary(Node root)
        {
            if (root == null) return;
            if (root.right != null)
            {
                printRightBoundary(root.right);
                Console.WriteLine("{0} ", root.value);
            }
            else if (root.left != null)
            {
                printRightBoundary(root.left);
                Console.WriteLine("{0} ", root.value);
            }
        }

        void printBoundary(Node root)
        {
            if (root != null)
            {
                Console.WriteLine("{0} ", root.value);

                printLeftBoundary(root.left);

                printLeafBoundary(root);

                printRightBoundary(root.right);
            }
        }







        public Node insert(Node root, int v)
         {
             if (root == null)
             {
                 root = new Node();
                 root.value = v;
             }
             else if (v < root.value)
             {
                 root.left = insert(root.left, v);
             }
             else
             {
                 root.right = insert(root.right, v);
             }

             return root;
         }

         public void traverse(Node root)
         {
             if (root == null)
             {
                 return;
             }

             traverse(root.left);
             traverse(root.right);
         }
        //**************************************************************
        ////Depth First Traversals:
        ////(a) Inorder(Left, Root, Right) : 4 2 5 1 3
        ////(b) Preorder(Root, Left, Right) : 1 2 4 5 3
        ////(c) Postorder(Left, Right, Root) : 4 5 2 3 1

        ////// Breadth First or Level Order Traversal : 1 2 3 4 5


        //  ************************************************************* //

        void printPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree
            printPostorder(node.left);
            printPostorder(node.right);
            Console.WriteLine(node.value + " ");
        }

        /* Given a binary tree, print its nodes in inorder*/
        void printInorder(Node node)
        {
            if (node == null)
                return;

            
            printInorder(node.left);
            Console.WriteLine(node.value + " ");
            printInorder(node.right);
        }

        /* Given a binary tree, print its nodes in preorder*/
        void printPreorder(Node node)
        {
            if (node == null)
                return;

             
            Console.WriteLine  (node.value + " ");
            printPreorder(node.left);
            printPreorder(node.right);
        }



        public bool isBST(Node root)
        {
            return isBST(root, int.MinValue, int.MaxValue);
        }

        private bool isBST(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }
            if (root.value <= min || root.value > max)
            {
                return false;
            }
            return isBST(root.left, min, root.value) && isBST(root.right, root.value, max);
        }


        // https://www.youtube.com/watch?v=86g8jAQug04

        // Level Oreder traversal 
        public void LevelOrder(Node root)
        {
            if (root == null) return;

            Queue<Node> Q = new Queue<Node>();
            Q.Enqueue(root);
            while (Q != null)
            {
                Node current = Q.Peek();
                Console.WriteLine(current.value);
                if (current.left != null) Q.Enqueue(current.left);
                if (current.left != null) Q.Enqueue(current.right);
                 Q.Dequeue();
            }

        }
        //  Height Of Binary Tree
        public int height(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            int leftHeight = height(root.left);
            int rightHeight = height(root.right);

            if (leftHeight >  rightHeight)
               return   leftHeight + 1;
             else
                return  rightHeight + 1;
        }

        //https://www.youtube.com/watch?v=EoxLxABkf5g
        //Lowest Common Ancestor in a Binary Search Tree
        public Node findLCA(Node root, int v1, int v2)
        {
            if (root == null) return null;

            if (v1 > root.value && v2 > root.value)

                return findLCA(root.right, v1, v2);


            else if (v1 < root.value && v2 < root.value)

                return findLCA(root.left, v1, v2);
            else

                return root;
        }

    }

 
    class BinarySearchTree
     {
         static void Main(string[] args)
         {
             Node root = null;
             Tree bst = new Tree();
             int SIZE = 2000000;
             int[] a = new int[SIZE];

             Console.WriteLine("Generating random array with {0} values...", SIZE);

             Random random = new Random();

             Stopwatch watch = Stopwatch.StartNew();

             for (int i = 0; i < SIZE; i++)
             {
                 a[i] = random.Next(10000);
             }

             watch.Stop();

             Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
             Console.WriteLine();
             Console.WriteLine("Filling the tree with {0} nodes...", SIZE);

             watch = Stopwatch.StartNew();

             for (int i = 0; i < SIZE; i++)
             {
                 root = bst.insert(root, a[i]);
             }

             watch.Stop();

             Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
             Console.WriteLine();
             Console.WriteLine("Traversing all {0} nodes in tree...", SIZE);

             watch = Stopwatch.StartNew();

             bst.traverse(root);

             watch.Stop();

             Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
             Console.WriteLine();

             Console.ReadKey();
         }
     }
 }

   