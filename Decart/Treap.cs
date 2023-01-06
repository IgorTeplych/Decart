using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decart
{
    public class Treap
    {
        Node _root;
        public Treap(Node root)
        {
            _root = root;
        }
        public Node Root
        {
            get { return _root; }
            set { _root = value; }
        }

        void Split(int key, Node root, ref Node left, ref Node right)
        {
            Node tree = null;
            if (root.Key < key)
            {
                if (root.Right == null)
                    right = null;
                else
                    Split(key, root.Right, ref tree, ref right);
                left = new Node(root.Key, root.Priority, root.Left, tree);
            }
            else
            {
                if (root.Left == null)
                    left = null;
                else
                    Split(key, root.Left, ref left, ref tree);
                right = new Node(root.Key, root.Priority, tree, root.Right);
            }
        }
        public Node Merge(Node left, Node right)
        {
            if (left == null) return right;
            if (right == null) return left;

            if (left.Priority > right.Priority)
            {
                var newR = Merge(left.Right, right);
                return new Node(left.Key, left.Priority, left.Left, newR);
            }
            else
            {
                var newL = Merge(left, right.Left);
                return new Node(right.Key, right.Priority, newL, right.Right);
            }
        }
        static Random random = new Random();
        public Node Add(int key)
        {
            Node left = null;
            Node right = null;
            Split(key, Root, ref left, ref left);
            Node newNode = new Node(key, random.Next());
            return Merge(Merge(left, newNode), right);
        }
    }
}
