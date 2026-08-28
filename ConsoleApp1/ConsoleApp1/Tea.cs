public class Tea : Menu
{
    public Tea() : base("티", 1000, Category.Drink)
    {
        
    }

    public override int CalculatePrice()
    {
        return price;
    }
}