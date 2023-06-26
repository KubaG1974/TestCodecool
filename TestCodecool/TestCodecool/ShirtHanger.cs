namespace TestCodecool;

public class ShirtHanger : Hanger
{
    public ShirtHanger()
    {
        IsEmpty = true;
        Clothes = new List<Clothing>();
    }

    public override bool CanHangClothing(Clothing clothing)
    {
        return IsEmpty && (clothing.Type == "shirt" || clothing.Type == "blouse");
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
