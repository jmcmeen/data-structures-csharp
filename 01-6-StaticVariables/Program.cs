public class Program
{
    private static void Main(string[] args)
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

        foreach(Thing thing in things)
        {
            Console.WriteLine(thing);
        }
    }
}

public class Thing
{
    public string Stuff { get; set; }
    public byte Byte { get; set; }
    public int Id { get; set; }
    public static int NumThings { get; set; }

    public Thing() 
    {
        Id = NumThings;
        NumThings += 1;
    }

    public override string ToString()
    {
        return $"{Id},{Stuff},{Byte},{NumThings}";
    }
}
