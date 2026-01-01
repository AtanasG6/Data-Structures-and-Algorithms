namespace Lists;

public class Program
{
    public static void Main()
    {
        CustomList list = new CustomList();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);
        }

        Console.WriteLine(list[2]);

        list[5] = 42;

        Console.WriteLine(list[5]);

        Console.WriteLine($"Element at index 3 before insert: {list[3]}");

        list.Insert(3, 99);

        Console.WriteLine($"Element at index 3 after insert: {list[3]}");
    }
}
