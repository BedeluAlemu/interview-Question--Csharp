using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvlTree
{
    class Node
    {
        public Node rchild;
        public Node lchild;
        public int balance;
        public int info;
        public Node(int data)
        {
            rchild = null;
            lchild = null;
            balance = 0;
            info = data;

        }
    }
}
