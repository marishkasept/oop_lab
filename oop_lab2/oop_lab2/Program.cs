using System;

class Program
{
    static void Main(string[] args)
    {
        var director = new Director();
        var builder = new ChocoTartarosBuilder();
        director.Builder = builder;

        Console.WriteLine("Simple ice cream:");
        director.BuildSimpleIceCream();
        Console.WriteLine(builder.GetProduct().ListIngredients());

        Console.WriteLine("Full featured ice cream:");
        director.BuildFullFeaturedIceCream();
        Console.WriteLine(builder.GetProduct().ListIngredients());
    }
}
