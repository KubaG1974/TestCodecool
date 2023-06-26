namespace TestCodecool;

class Program
{
    static void Main()
    {
        Wardrobe wardrobe = new Wardrobe(5);

        Clothing shirt1 = new Clothing("Brand1", "shirt");
        Clothing blouse1 = new Clothing("Brand2", "blouse");
        Clothing trousers1 = new Clothing("Brand3", "trousers");

        bool success1 = wardrobe.HangClothing(shirt1);
        bool success2 = wardrobe.HangClothing(blouse1);
        bool success3 = wardrobe.HangClothing(trousers1);

        bool hasEmptyHangerForShirt = wardrobe.CheckEmptyHangerForType("shirt");
        bool hasEmptyHangerForSkirt = wardrobe.CheckEmptyHangerForType("skirt");

        Clothing takenClothing = wardrobe.TakeOutClothing("2");

        Console.WriteLine("Clothing successfully hung: " + (success1 && success2 && success3));
        Console.WriteLine("Has empty hanger for shirt: " + hasEmptyHangerForShirt);
        Console.WriteLine("Has empty hanger for skirt: " + hasEmptyHangerForSkirt);
        Console.WriteLine("Clothing taken out: " + (takenClothing != null ? takenClothing.Brand : "Not found"));

        Console.ReadLine();
    }
}
