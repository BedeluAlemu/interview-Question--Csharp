using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvlTree
{
    class AVLTree
    {
        private Node root;
        static bool taller;
        static bool shorter;
        public AVLTree()
        {
            root = null;

        }
        public bool IsEmpty()
        {
            return (root == null);

        }
        public void Display()
        {
            Display(root, 0);
            Console.WriteLine();

        }

        public void PrintBinaryTree()
        {
            PrintBinaryTree(root, 0);
        }

        private void PrintBinaryTree(Node p, int level)
        {
            if (p == null)
                return;
            PrintBinaryTree(p.rchild, level + 1);

            if (level != 0)
            {
                for (int i = 0; i < level - 1; i++)
                    Console.Write("|\t");
                Console.WriteLine("|-------" + p.info);
            }
            else
                Console.WriteLine(p.info);
            PrintBinaryTree(p.lchild, level + 1);
        }
        private void Display(Node p, int level)
        {
            int i;
            if (p == null)
            {
                return;

            }
            level++;
            Display(p.rchild, level);
            Console.WriteLine();
            for (i = 0; i < level; i++)
                Console.WriteLine("  ");
            Console.WriteLine(p.info);
            level++;
            Display(p.rchild, level);
        }

        public void Insert(int data)
        {
            root = Insert(root, data);

        }
        public Node Insert(Node p, int data)
        {
            if (p == null)
            {
                p = new Node(data);
                taller = true;


            }
            else if (data < p.info)
            {
                p.lchild = Insert(p.lchild, data);

                if (taller == true)
                    p = InserttionLeftSubTreeCheck(p); // 

            }
            else if (data > p.info)
            {
                p.rchild = Insert(p.rchild, data);

                if (taller == true)
                    p = InserttionRightSubTreeCheck(p);

            }
            else
            {
                Console.WriteLine(data + " already exist");
                taller = false;
            }
            return p;
        }
        private Node InserttionLeftSubTreeCheck(Node p)
        {
            switch (p.balance)
            {
                case 0:  // was balanced  now left heavy 
                    p.balance = 1;
                    break;

                case 1: // was left heavy now balanced 
                    p = InserttionLeftBalance(p);
                    taller = false;
                    break;

                case -1: // was right heavy now balanced 
                    p.balance = 0;
                    taller = false;
                    break;


                default:
                    break;
            }
            return p;

        }


        private Node InserttionRightSubTreeCheck(Node p)
        {
            switch (p.balance)
            {
                case 0:  // was balanced  now Right heavy 
                    p.balance = -1;
                    break;

                case 1: // was left heavy now balanced 
                    p.balance = 0;
                    taller = false;
                    break;

                case -1: // was right heavy now balanced 
                    p = InserttionRighBalance(p);
                    taller = false;
                    break;


                default:
                    break;
            }
            return p;
        }
        private Node InserttionLeftBalance(Node p)
        {
            Node a, b;

            a = p.lchild;

            if (a.balance == 1)
            {
                p.balance = 0;
                a.balance = 0;
                p = RotateRight(p);

            }
            else
            {
                b = a.rchild;
                switch (b.balance)
                {
                    case 1:
                        p.balance = -1;
                        a.balance = 0;
                        break;
                    case -1:
                        p.balance = 0;
                        a.balance = 1;
                        break;
                    case 0:
                        p.balance = 0;
                        a.balance = 0;
                        break;
                    default:
                        break;
                }
                b.balance = 0;
                p.lchild = RotateLeft(a);
                p = RotateRight(p);

            }
            return p;
        }


        private Node InserttionRighBalance(Node p)
        {
            Node a, b;

            a = p.rchild;

            if (a.balance == -1)
            {
                p.balance = 0;
                a.balance = 0;
                p = RotateLeft(p);

            }
            else
            {
                b = a.lchild;
                switch (b.balance)
                {
                    case 1:
                        p.balance = 0;
                        a.balance = -1;
                        break;
                    case -1:
                        p.balance = 1;
                        a.balance = 0;
                        break;
                    case 0:
                        p.balance = 0;
                        a.balance = 0;
                        break;
                    default:
                        break;





                }
                b.balance = 0;
                p.rchild = RotateRight(a);
                p = RotateLeft(p);
            }
            return p;

        }
        private Node RotateLeft(Node p)
        {
            Node a = p.rchild;
            p.rchild = a.lchild;
            a.lchild = p;
            return a;


        }

        private Node RotateRight(Node p)
        {
            Node a = p.lchild;
            p.lchild = a.rchild;
            a.rchild = p;
            return a;

        }



    }
}
