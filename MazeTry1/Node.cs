using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace MazeTry1
{
    public class Node
    {
        internal int data;
        internal Node? next;
        public Node(int d)
        {
            data = d;
            next = null;
            //int value;            
            Node Left;
            Node Right;   
        }
    }
}
