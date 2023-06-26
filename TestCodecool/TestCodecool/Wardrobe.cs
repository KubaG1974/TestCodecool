namespace TestCodecool;

public class Wardrobe
{
    private List<Hanger> hangers;

    public Wardrobe(int capacity)
    {
        hangers = new List<Hanger>(capacity);

        for (int i = 0; i < capacity; i++)
        {
            if (i % 2 == 0)
            {
                hangers.Add(new ShirtHanger());
            }
            else
            {
                hangers.Add(new ComboHanger());
            }
        }
    }

    public bool HangClothing(Clothing clothing)
    {
        if (clothing == null)
        {
            throw new ArgumentNullException(nameof(clothing), "Clothing cannot be null.");
        }

        foreach (Hanger hanger in hangers)
        {
            if (hanger.CanHangClothing(clothing))
            {
                hanger.HangClothing(clothing);
                return true;
            }
        }

        return false;
    }

    public Clothing TakeOutClothing(string clothingId)
    {
        if (clothingId == null)
        {
            throw new ArgumentNullException(nameof(clothingId), "Clothing ID cannot be null.");
        }

        foreach (Hanger hanger in hangers)
        {
            if (!hanger.IsEmpty && hanger.Clothes != null)
            {
                Clothing clothing = hanger.Clothes.Find(c => c.Id == clothingId);
                if (clothing != null)
                {
                    hanger.RemoveClothing(clothing);
                    return clothing;
                }
            }
        }

        return null;
    }

    public bool CheckEmptyHangerForType(string type)
    {
        if (type == null)
        {
            throw new ArgumentNullException(nameof(type), "Type cannot be null.");
        }

        foreach (Hanger hanger in hangers)
        {
            if (hanger.CanHangClothing(new Clothing("", type))) 
            {
                return true;
            }
        }

        return false;
    }

}

