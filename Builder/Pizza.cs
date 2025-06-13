namespace design_patterns.Builder;

public class Pizza
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }

    public Pizza(string name)
    {
        Name = name;
        Ingredients = new List<string>();
    }

    public void AddIngrendients(string ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public override string ToString()
    {
        return $"Pizza {Name}, ingredients : {string.Join(",", Ingredients)}";
    }
    
    public abstract class  PizzaBuilder
    {
        public Pizza Pizza { get; private set; }

        public PizzaBuilder(string name)
        {
            Pizza = new Pizza(name);
        }

        public abstract void AddIngredient();
        public abstract void AddBase();
    }

    public class MargheritaBuilder : PizzaBuilder
    {
        public MargheritaBuilder()
            :base(" Margherita")
        {
            
        }

        public override void AddBase()
        {
            Pizza.AddIngrendients("Tomato sauce");
        }

        public override void AddIngredient()
        {
            throw new NotImplementedException();
        }
    }

}