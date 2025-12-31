namespace Trees;

public class Program
{
    public static void Main()
    {
        TreeNode<int> c1 = new TreeNode<int>(1),
                      c2 = new TreeNode<int>(12),
                      c3 = new TreeNode<int>(31);

        TreeNode<int> c4 = new TreeNode<int>(23),
                      c5 = new TreeNode<int>(6);

        TreeNode<int> b1 = new TreeNode<int>(19, c1, c2, c3),
                      b2 = new TreeNode<int>(21),
                      b3 = new TreeNode<int>(14, c4, c5);

        TreeNode<int> a1 = new TreeNode<int>(7, b1, b2, b3);

        Print(a1, 0);
        Console.WriteLine(string.Join(", ", PreOrderTraversal(a1)));
        Console.WriteLine(string.Join(", ", PostOrderTraversal(a1)));
        Console.WriteLine(string.Join(", ", BFS(a1)));
    }

    private static void Print<T>(TreeNode<T> node, int depth)
    {
        Console.WriteLine($"{new string(' ', depth * 2)}{node.Value}");

        foreach (TreeNode<T> childNode in node.Children)
            Print(childNode, depth + 1);
    }

    private static IEnumerable<T> PreOrderTraversal<T>(TreeNode<T> node)
    {
        yield return node.Value;

        foreach (TreeNode<T> childNode in node.Children)
        {
            foreach (T childValue in PreOrderTraversal(childNode))
                yield return childValue;
        }
    }

    private static IEnumerable<T> PostOrderTraversal<T>(TreeNode<T> node)
    {
        foreach (TreeNode<T> childNode in node.Children)
        {
            foreach (T childValue in PostOrderTraversal(childNode))
                yield return childValue;
        }

        yield return node.Value;
    }

    private static IEnumerable<T> BFS<T>(TreeNode<T> root)
    {
        Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();
        queue.Enqueue(root);

        while (queue.TryDequeue(out TreeNode<T>? node))
        {
            yield return node.Value;

            foreach (TreeNode<T> childNode in node.Children)
                queue.Enqueue(childNode);
        }
    }
}
