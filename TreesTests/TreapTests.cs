using Decart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesTests
{
    public class TreapTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void InsertMethodTest()
        {
            Treap treap = new Treap(0);
            treap.Insert(200);
            treap.Insert(400);
            treap.Insert(500);
            treap.Insert(-20);
            treap.Insert(550);
            treap.Insert(-200);
        }
        [Test]
        public void SearchMethodTest()
        {
            Treap treap = new Treap(0);
            treap.Insert(200);
            treap.Insert(400);
            treap.Insert(500);
            treap.Insert(-20);
            treap.Insert(550);
            treap.Insert(-200);
            treap.Insert(-1);
            treap.Insert(-9);
            treap.Insert(-13);
            treap.Insert(89);
            treap.Insert(27);

            Assert.AreEqual(treap.Search(0), true);
            Assert.AreEqual(treap.Search(200), true);
            Assert.AreEqual(treap.Search(400), true);
            Assert.AreEqual(treap.Search(500), true);
            Assert.AreEqual(treap.Search(-20), true);
            Assert.AreEqual(treap.Search(550), true);
            Assert.AreEqual(treap.Search(-200), true);
            Assert.AreEqual(treap.Search(-1), true);
            Assert.AreEqual(treap.Search(-9), true);
            Assert.AreEqual(treap.Search(-13), true);
            Assert.AreEqual(treap.Search(89), true);
            Assert.AreEqual(treap.Search(27), true);

            Assert.AreEqual(treap.Search(207), false);
            Assert.AreEqual(treap.Search(1000), false);
            Assert.AreEqual(treap.Search(100), false);
        }
    }
}
