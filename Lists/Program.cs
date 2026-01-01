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
    }
}
