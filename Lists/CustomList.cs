namespace Lists;

public class CustomList
{
    private int[] _array;
    public int Count { get; private set; }

    public CustomList()
    {
        _array = new int[4];
        Count = 0;
    }

    public void Add(int element)
    {
        if (this.Count == this._array.Length)
            this.Grow();

        this._array[this.Count] = element;
        this.Count++;
    }

    public void Grow()
    {
        // TODO: Increase the size of the internal array
    }
}
