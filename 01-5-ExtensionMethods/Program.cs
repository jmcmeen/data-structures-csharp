internal static class Program
{
    private static void Main()
    {
        const int ITERATIONS = 100;

        List<Thing> things = new List<Thing>();

        for (int i = 0; i < ITERATIONS; i++)
        {
            things.Add(new Thing()
            {
                Stuff = "Hello World",
                Byte = (byte)i,
            });
        }

        things.ToStringArray();

        things.Average(x => x.Byte);
    }
}

public static class Extensions
{
    public static string[] ToStringArray(this List<Thing> things)
    {
        string[] array = new string[things.Count];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = things[i].ToString();
        }

        return array;
    }
}