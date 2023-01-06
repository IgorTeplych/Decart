using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decart
{
    public class Node
    {
        public Node() { }
        public Node(int key, int priority, Node left = null, Node right = null)
        {
            this.Key = key;
            this.Priority = priority;
            this.Left = left;
            this.Right = right;
        }
        public int Key { get; set; }
        public int Priority { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

    }
}
