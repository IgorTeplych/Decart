using Decart;
using System.Diagnostics;

public class Prorgamm
{
    public static void Main()
    {
        Console.WriteLine("ТЕСТЫ ПРОИЗВОДИТЕЛЬНОСТИ ДЕРЕВА TREAP");
        PerformanceTreapTests();
        Console.WriteLine();
        Console.WriteLine("ТЕСТЫ ПРОИЗВОДИТЕЛЬНОСТИ ДЕРЕВА BTREE");
        PerformanceBTreeTests();

        Console.ReadLine();
    }
    static void PerformanceTreapTests()
    {
        int N = 10000;
        int[] rndNum = GetRandomNumbers(N);
        int[] orderNum = GetOrderNumbers(N);

        Decart.Treap treap = new Decart.Treap(0);
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            treap.Insert(rndNum[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в [Treap] неупорядоченных чисел от 1 до {N} занимает: {sw.ElapsedTicks * 100} нс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            bool searh = treap.Search(random.Next(1, int.MaxValue));
        }
        sw.Stop();
        Console.WriteLine($"Поиск в этом [Treap] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");
        Console.WriteLine();

        treap = new Decart.Treap(0);
        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            treap.Insert(orderNum[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в дерево [Treap] упорядоченных по возрастанию чисел от 1 до {N} занимает: {sw.ElapsedTicks * 100} нс.");


        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            bool searh = treap.Search(random.Next(1, int.MaxValue));
        }
        sw.Stop();
        Console.WriteLine($"Поиск в этом [Treap] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");
    }
    static void PerformanceBTreeTests()
    {
        int N = 10000;
        int[] rndNum = GetRandomNumbers(N);
        int[] orderNum = GetOrderNumbers(N);

        BTree.Tree tree = new BTree.Tree();
        Stopwatch sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            tree.Insert(rndNum[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в [BTree] неупорядоченных чисел от 1 до {N} занимает: {sw.ElapsedTicks * 100} нс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            bool searh = tree.Contains(random.Next(1, int.MaxValue));
        }
        sw.Stop();
        Console.WriteLine($"Поиск в этом [BTree] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");
        Console.WriteLine();

        tree = new BTree.Tree();
        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < N; i++)
        {
            tree.Insert(orderNum[i]);
        }
        sw.Stop();
        Console.WriteLine($"Добавление в дерево [BTree] упорядоченных по возрастанию чисел от 1 до {N} занимает: {sw.ElapsedTicks * 100} нс.");

        sw = new Stopwatch();
        sw.Start();
        for (int i = 0; i < (N / 10); i++)
        {
            bool searh = tree.Contains(random.Next(1, int.MaxValue));
        }
        sw.Stop();
        Console.WriteLine($"Поиск в этом [BTree] {N / 10} случайных чисел занимает: {sw.ElapsedTicks * 100} нс.");
    }
    static Random random = new Random();
    static int[] GetRandomNumbers(int N)
    {
        int[] mass = new int[N];
        for (int i = 0; i < N; i++)
        {
            if (i != N)
                mass[i] = random.Next(1, int.MaxValue);
        }
        return mass;
    }

    static int[] GetOrderNumbers(int N)
    {
        int[] mass = new int[N];
        for (int i = 1; i < N; i++)
        {
            if (i != N)
                mass[i] = i;
        }
        return mass;
    }
}