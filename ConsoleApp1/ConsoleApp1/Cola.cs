public class Cola : Menu
{
    public Cola(): base("콜라", 1300, Category.음료)
    {
        
    }

    public override int CalculatePrice()
    {
        return price;
    }
}