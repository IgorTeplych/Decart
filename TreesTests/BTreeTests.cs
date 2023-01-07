namespace TreesTests
{
    using BTree;
    public class BTreeTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void InsertMethodTest()
        {
            Tree tree = new Tree();
            tree.Insert(10);
            tree.Insert(11);
            tree.Insert(9);
            tree.Insert(12);
            tree.Insert(13);
            tree.Insert(8);
            tree.Insert(7);
            tree.Insert(18);
            tree.Insert(27);

            Assert.AreEqual(tree.Root.Keys[0], 10);
            Assert.AreEqual(tree.Root.Keys[1], 12);

            Assert.AreEqual(tree.Root.Childs[0].Keys[0], 7);
            Assert.AreEqual(tree.Root.Childs[0].Keys[1], 8);
            Assert.AreEqual(tree.Root.Childs[0].Keys[2], 9);

            Assert.AreEqual(tree.Root.Childs[1].Keys[2], 13);

            Assert.AreEqual(tree.Root.Childs[2].Keys[2], 27);
            Assert.AreEqual(tree.Root.Childs[2].Keys[1], 18);
        }
        [Test]
        public void ContainsMethodTest()
        {
            Tree tree = new Tree();
            tree.Insert(10);
            tree.Insert(11);
            tree.Insert(9);
            tree.Insert(12);
            tree.Insert(13);
            tree.Insert(8);
            tree.Insert(7);
            tree.Insert(18);
            tree.Insert(27);

            Assert.AreEqual(true, tree.Contains(10));
            Assert.AreEqual(true, tree.Contains(11));
            Assert.AreEqual(true, tree.Contains(9));
            Assert.AreEqual(true, tree.Contains(12));
            Assert.AreEqual(true, tree.Contains(13));
            Assert.AreEqual(true, tree.Contains(8));
            Assert.AreEqual(true, tree.Contains(7));
            Assert.AreEqual(true, tree.Contains(18));
            Assert.AreEqual(true, tree.Contains(27));

            Assert.AreEqual(false, tree.Contains(270));
            Assert.AreEqual(false, tree.Contains(218));
        }
    }
}