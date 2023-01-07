using BTree;

public class Prorgamm
{
    static Random random = new Random();
    public static void Main()
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
  

        var vr = tree.Contains(18);
    }

}
