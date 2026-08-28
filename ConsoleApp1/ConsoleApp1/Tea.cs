public class Tea : Menu
{
    public Tea() : base("티", 1000, Category.음료)
    {
        
    }

    public override int CalculatePrice()
    {
        return price;
    }
}