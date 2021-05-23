using System.Collections.Generic;

public class IceCream
{
    private List<object> _ingredients = new List<object>();

    public void Add(string ingredient)
    {
        this._ingredients.Add(ingredient);
    }

    public string ListIngredients()
    {
        string str = string.Empty;

        for (int i = 0; i < this._ingredients.Count; i++)
        {
            str += this._ingredients[i] + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Ice cream ingredients: " + str + "\n";
    }
}
