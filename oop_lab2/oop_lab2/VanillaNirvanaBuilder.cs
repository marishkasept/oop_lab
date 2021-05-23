public class VanillaNirvanaBuilder : IceCreamBuilder
{
    private IceCream _icecream = new IceCream();

    public VanillaNirvanaBuilder()
    {
        this.Reset();
    }

    public void Reset()
    {
        this._icecream = new IceCream();
    }

    public void BuildCup()
    {
        this._icecream.Add("waffle cone");
    }

    public void BuildFlavor()
    {
        this._icecream.Add("sweet vanilla ball");
    }

    public void BuildTopping()
    {
        this._icecream.Add("flaked coconut");
    }

    public IceCream GetProduct()
    {
        IceCream result = this._icecream;

        this.Reset();

        return result;
    }
}
