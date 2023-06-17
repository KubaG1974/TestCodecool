namespace TestCodecool;

public class Wardrobe
{
    private List<Hanger> hangers;

    public Wardrobe(int capacity)
    {
        hangers = new List<Hanger>(capacity);
        for (int i = 0; i < capacity; i++)
        {
            hangers.Add(new Hanger());
        }
    }    
}