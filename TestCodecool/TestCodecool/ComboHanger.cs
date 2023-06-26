namespace TestCodecool;

public class ComboHanger : Hanger
{
    public ComboHanger()
    {
        IsEmpty = true;
        Clothes = new List<Clothing>();
    }

    public override bool CanHangClothing(Clothing clothing)
    {
        if (IsEmpty)
        {
            return true;
        }
        else if (clothing.Type == "shirt" || clothing.Type == "blouse")
        {
            return Clothes.Exists(c => c.Type == "shirt" || c.Type == "blouse");
        }
        else if (clothing.Type == "trousers" || clothing.Type == "skirt")
        {
            return Clothes.Exists(c => c.Type == "trousers" || c.Type == "skirt");
        }

        return false;
    }

    public override void HangClothing(Clothing clothing)
    {
        if (clothing != null && CanHangClothing(clothing))
        {
            Clothes.Add(clothing);
            IsEmpty = false;
        }
    }

    public override void RemoveClothing(Clothing clothing)
    {
        if (clothing != null)
        {
            Clothes.Remove(clothing);
            if (Clothes.Count == 0)
            {
                IsEmpty = true;
            }
        }
    }
}
