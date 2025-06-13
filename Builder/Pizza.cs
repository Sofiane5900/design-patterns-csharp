namespace design_patterns.Builder;

public class Pizza
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }

    public Pizza(string name)
    {
        Name = name;
    }

    public void AddIngrendients(string ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public override string ToString()
    {
        return $"Pizza {Name}, ingredients : {string.Join(",", Ingredients)}";
    }
}