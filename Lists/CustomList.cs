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
        if (this.Count == this._array.Length)
            this.Grow();

        this._array[this.Count] = element;
        this.Count++;
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
}
