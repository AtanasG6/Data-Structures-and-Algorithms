namespace Lists;

public class Program
{
    public static void Main()
    {
        CustomList list = new CustomList();
        list.Add(1);
        list.Add(13);
        list.Add(7);

        Console.WriteLine(list.Count);
    }
}
