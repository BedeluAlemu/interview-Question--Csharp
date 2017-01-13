using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryIsbalanced
{


     class Node
    {
        public int value;
        public Node right;
        public Node left;
    }
    class Program
    {
        

        public bool isBalanced(Node n)
        {
            if (balancedHeight(n) > -1) return true;
            return false;
        }

        public int balancedHeight(Node n)
        {
            if (n == null) return 0;
            int h1 = balancedHeight(n.right);
            int h2 = balancedHeight(n.left);

            if (h1 == -1 || h2 == -1) return -1;
            
            if (Math.Abs(h1 - h2) > 1) return -1;


            if (h1 > h2) return h1 + 1;

            return h2 + 1;
        }



        static void Main(string[] args)
        {
        }
    }
}
