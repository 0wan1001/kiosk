public class Toothbrush : Menu
{
    public Toothbrush() : base("칫솔", 3000, Category.생필품)
    {
        
    }

    public override int CalculatePrice()
    {
        return price;
    }
}