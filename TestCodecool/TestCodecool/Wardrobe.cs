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

    public bool HangClothing(Clothing clothing)
    {
        foreach (Hanger hanger in hangers)
        {
            if (hanger.IsEmpty)
            {
                if (hanger.Clothes == null)
                {
                    hanger.Clothes = new List<Clothing>();
                }

                hanger.Clothes.Add(clothing);
                hanger.IsEmpty = false;
                return true;
            }
            else if (CanHangOnSameHanger(hanger, clothing))
            {
                hanger.Clothes.Add(clothing);
                return true;
            }
        }

        return false;
    }

    private bool CanHangOnSameHanger(Hanger hanger, Clothing clothing)
    {
        if (clothing.Type == "shirt" || clothing.Type == "blouse")
        {
            return hanger.Clothes != null && hanger.Clothes.Exists(c => c.Type == "shirt" || c.Type == "blouse");
        }
        else if (clothing.Type == "trousers" || clothing.Type == "skirt")
        {
            return hanger.Clothes != null && hanger.Clothes.Exists(c => c.Type == "trousers" || c.Type == "skirt");
        }

        return false;
    }
}