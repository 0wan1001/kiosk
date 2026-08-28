public class Toothbrush : Menu
{
    public Toothbrush() : base("칫솔", 3000, Category.Dailynecessities)
    {
        
    }

    public override int CalculatePrice()
    {
        return price;
    }
}