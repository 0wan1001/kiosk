public abstract class Freshness : Menu
{
    protected int freshness;

    public Freshness(string _name, int _price, int _freshness) : base(_name, _price, Category.빵)
    {
        freshness = _freshness;
    }
    public override int CalculatePrice()
    {
        double rate = freshness / 100f;
        int result = price - (int)(price * rate);
        return result;
    }
    
}