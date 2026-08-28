public class ShoppingCart
{
    public Menu menu;
    protected int count { get; set; }
    
    public ShoppingCart(Menu _menu, int _count)
    {
        menu = _menu;
        count = _count;
    }

    public int GetPrice()
    {
        return menu.CalculatePrice() * count;
    }
}