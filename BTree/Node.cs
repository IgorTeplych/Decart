using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class Node
    {
        public int Size { get; set; }
        public Node(int size = 2, bool leaf = true)
        {
            Size = size;
            Keys = new int[Size * 2 - 1];
            Childs = new Node[Size * 2];
            IsLeaf = leaf;
        }
        public int Capacity { get; set; }
        public int[] Keys { get; set; }
        public bool IsLeaf { get; set; }
        public Node[] Childs { get; set; }
    }
}
