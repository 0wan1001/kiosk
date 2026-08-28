public enum Category
{
    Drink,
    Bread,
    Dailynecessities
}

public abstract class Menu
{
    public string name;
    protected int price { get; set; }
    public Category category;
    
    public Menu(string _name, int _price, Category _category)
    {
        name = _name;
        price = _price;
        category = _category;
    }
    public abstract int CalculatePrice();
}