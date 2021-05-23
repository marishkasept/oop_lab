public class Director
{
    private IceCreamBuilder _builder;

    public IceCreamBuilder Builder
    {
        set { _builder = value; }
    }

    public void BuildSimpleIceCream()
    {
        this._builder.BuildCup();
        this._builder.BuildFlavor();
    }

    public void BuildFullFeaturedIceCream()
    {
        this._builder.BuildCup();
        this._builder.BuildFlavor();
        this._builder.BuildTopping();
    }
}
