public class ChocoTartarosBuilder : IceCreamBuilder
{
    private IceCream _icecream = new IceCream();

    public ChocoTartarosBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._icecream = new IceCream();
    }

    public void BuildCup()
    {
        this._icecream.Add("bubble waffle");
    }

    public void BuildFlavor()
    {
        this._icecream.Add("dark chocolate ball");
    }

    public void BuildTopping()
    {
        this._icecream.Add("chocolate chip");
    }

    public IceCream GetProduct()
    {
        IceCream result = this._icecream;

        this.Reset();

        return result;
    }
}
