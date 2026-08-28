public enum Category
{
    음료,
    빵,
    생필품
}

public abstract class Menu
{
    public string name;
    public int price;
    public Category category;
    
    public Menu(string _name, int _price, Category _category)
    {
        name = _name;
        price = _price;
        category = _category;
    }
    public abstract int CalculatePrice();
}