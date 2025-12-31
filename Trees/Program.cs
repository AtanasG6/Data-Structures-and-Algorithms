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

    }
}
