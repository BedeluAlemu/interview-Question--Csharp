using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvlTree
{
    class Demo
    {
        enum choosen { display = 1, insert = 2, delete = 3, inorder = 4, quit = 5 };
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();

            int choice, data;


            while (true)
            {

                Console.WriteLine("1.Displaye Tree");
                Console.WriteLine("2.Insert a new node");
                Console.WriteLine("3.Delete a node");
                Console.WriteLine("4.Inorder Traversal");
                Console.WriteLine("5.Quit");
                Console.WriteLine("Enter your choice");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == (int)choosen.quit)
                    break;



                switch (choice)
                {
                    case (int)choosen.display:

                        tree.PrintBinaryTree();
                        break;
                    case (int)choosen.insert:
                        Console.Clear();
                        Console.WriteLine("Enter the data to be inserted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        tree.Insert(data);
                        break;
                    case (int)choosen.delete:
                        Console.Clear();
                        Console.WriteLine("Enter the data to be deleted :");
                        data = Convert.ToInt32(Console.ReadLine());
                        //   tree.Delete(data);
                        break;


                    default:
                        break;
                }
            }
        }
    }
}
