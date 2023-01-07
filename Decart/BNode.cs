using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decart
{
    internal class BNode
    {
        public int Key { get; set; }
        public bool Leaf { get; set; }
        public BNode Left { get; set; }
        public BNode Right { get; set; }
        public BNode Parrent { get; set; }
    }
}
