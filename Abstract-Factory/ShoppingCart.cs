namespace design_patterns.Abstract_Factory;


public class Customer
{
    public int[] Orders { get; set; } = Array.Empty<int>();
}
public class ShoppingCart
{
    private readonly IVipShoppingFactory factory;
    public ShoppingCart(IVipShoppingFactory factory)
    {
        this.factory = factory;
    }
    public void CreateCommand()
    {
        var priority = factory.GetPriorite().Priority;
        var percentage = factory.GetReduction().Percentage;
        
        Console.WriteLine("Priority Client = " + priority);
        Console.WriteLine("Purcentage = " + percentage);

    }
}