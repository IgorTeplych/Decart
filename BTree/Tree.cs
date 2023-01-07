using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class Tree
    {
        Node _root; 
        public Tree(int size = 2)
        {
            _root = new Node(size);
        }
        public Node Root
        {
            get { return _root; }
        }
        public void Insert(int key)
        {
            Node rt = _root;
            if (rt.Capacity == rt.Keys.Length)
            {
                Node nd = new Node();
                _root = nd;
                nd.IsLeaf = false;
                nd.Childs[0] = rt;
                Split(nd, 0, rt);
                Insert(key, nd);
            }
            else
            {
                Insert(key, _root);
            }
        }

        void Insert(int key, Node node)
        {
            if (node.IsLeaf)
            {
                int count = node.Capacity - 1;
                while (count >= 0 && key < node.Keys[count])
                {
                    node.Keys[count + 1] = node.Keys[count];
                    count--;
                }
                node.Keys[count + 1] = key;
                node.Capacity++;
            }
            else
            {
                int count = node.Capacity - 1;
                while (count >= 0 && key < node.Keys[count])
                {
                    count--;
                }
                count++;
                Node nd = node.Childs[count];
                if (nd.Capacity == nd.Keys.Length)
                {
                    Split(node, count, nd);
                    if (key > node.Keys[count])
                    {
                        count++;
                    }
                }
                Insert(key, node.Childs[count]);
            }
        }

        void Split(Node node1, int pos, Node node2)
        {
            Node nd = new Node();
            nd.IsLeaf = node2.IsLeaf;
            nd.Capacity = nd.Size - 1;

            int count = 0;
            while(count < nd.Size - 1)
            {
                nd.Keys[count] = node2.Keys[count + node2.Size];
                count++;
            }

            count = 0;
            while(!node2.IsLeaf && count < nd.Size)
            {
                nd.Childs[count] = node2.Childs[count + node2.Size];
                count++;
            }

            node2.Capacity = node2.Size - 1;
            count = node1.Capacity;
            while(count >= pos + 1)
            {
                node1.Childs[count + 1] = node1.Childs[count];
                count--;
            }
            node1.Childs[pos + 1] = nd;


            count = node1.Capacity - 1;
            while (count >= pos)
            {
                node1.Keys[count + 1] = node1.Keys[count];
                count--;
            }

            node1.Keys[pos] = node2.Keys[node2.Size - 1];
            node1.Capacity = node1.Capacity + 1;
        }

        public bool Contains(int key)
        {
            Node result;
            Search(key, _root, out result);
            
            return result == null ? false: true;
        }

        void Search(int key, Node node, out Node result)
        {
            if (node == null)
            {
                result = null;
                return;
            }

            int count = 0;
            while (count < node.Capacity && key > node.Keys[count])
            {
                count++;
            }

            if (count < node.Capacity && key == node.Keys[count])
            {
                result = node;
                return;
            }

            if(node.IsLeaf)
            {
                result = null;
            }
            else
            {
                Search(key, node.Childs[count], out result);
            }
        }
    }
}
