
public class Thing
{
    public string Stuff { get; set; }
    public byte Byte { get; set; }

    public string ToString()
    {
        return $"{Stuff},{Byte}";
    }
}

