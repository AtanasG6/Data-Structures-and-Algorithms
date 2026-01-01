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

    public int this[int index]
    {
        get
        {
            this.ValidateIndex(index);
            return this._array[index];
        }
        set
        {
            this.ValidateIndex(index);
            this._array[index] = value;
        }
    }

    public void Add(int element)
    {
        this.GrowIfNeeded();

        this._array[this.Count] = element;
        this.Count++;
    }

    public void Insert(int index, int element)
    {
        if (index == this.Count)
        {
            this.Add(element);
            return;
        }

        this.ValidateIndex(index);

        this.GrowIfNeeded();

        this.ShiftRight(this.Count - 1, index);

        this._array[index] = element;
        this.Count++;
    }

    public void RemoveAt(int index)
    {
        this.ValidateIndex(index);

        this.ShiftLeft(index + 1, this.Count - 1);

        this.Count--;
    }

    private void GrowIfNeeded()
    {
        if (this.Count == this._array.Length)
            this.Grow();
    }

    private void Grow()
    {
        int[] newArray = new int[this._array.Length * 2];
        Array.Copy(this._array, newArray, this._array.Length);
        this._array = newArray;
    }

    private void ValidateIndex(int index)
    {
        if (index < 0 || index >= this.Count)
            throw new IndexOutOfRangeException("Index was out of range.");
    }

    private void ShiftRight(int start, int end)
    {
        for (int i = end; i >= start; i--)
            this._array[i + 1] = this._array[i];
    }

    private void ShiftLeft(int start, int end)
    {
        for (int i = start; i <= end; i++)
            this._array[i - 1] = this._array[i];
    }
}
