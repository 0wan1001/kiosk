public abstract class Freshness : Menu
{
    protected int freshness;

    public Freshness(string _name, int _price, int _freshness) : base(_name, _price, Category.Bread)
    {
        freshness = _freshness;
    }
    public override int CalculatePrice()
    {
        double rate = freshness / 100.0;
        int result = (int)(price * rate);
        return result;
    }
    
}