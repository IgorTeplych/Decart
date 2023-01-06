using Decart;

public class Prorgamm
{
    static Random random = new Random();
    public static void Main()
    {
        Treap treap = new Treap(new Node { Key = 20, Priority = random.Next()});
        treap.Root = treap.Add(25);
        treap.Root = treap.Add(26);
        treap.Root = treap.Add(27);
        treap.Root = treap.Add(28);
        treap.Root = treap.Add(29);
        treap.Root = treap.Add(30);
    }
}