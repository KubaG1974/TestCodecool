namespace TestCodecool;

public class Clothing
{
    public string Id { get; }
    public string Brand { get; set; }
    public string Type { get; set; }

    public Clothing(string brand, string type)
    {
        Id = Guid.NewGuid().ToString();
        Brand = brand;
        Type = type;
    }
}
