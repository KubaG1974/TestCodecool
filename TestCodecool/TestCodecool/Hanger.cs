using System.Collections.Generic;

namespace TestCodecool;

public abstract class Hanger
{
    public bool IsEmpty { get; protected set; }
    public List<Clothing> Clothes { get; protected set; }

    public abstract bool CanHangClothing(Clothing clothing);
    public abstract void HangClothing(Clothing clothing);
    public abstract void RemoveClothing(Clothing clothing);
}
