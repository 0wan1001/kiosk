public class Cola : Menu
{
    public Cola(): base("콜라", 1300, Category.Drink)
    {
        
    }

    public override int CalculatePrice()
    {
        return price;
    }
}