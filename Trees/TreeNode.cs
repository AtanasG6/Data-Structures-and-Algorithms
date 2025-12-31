namespace Trees;

public class TreeNode<T>
{
    public T Value { get; set; }
    public IReadOnlyCollection<TreeNode<T>> Children { get; set; }

    public TreeNode(T value, params TreeNode<T>[] children)
    {
        this.Value = value;
        this.Children = children.AsReadOnly();
    }
}
