namespace design_patterns.Abstract_Factory;


public class Customer
{
    public int[] Orders { get; set; } = Array.Empty<int>();
}
public class ShoppingCart
{
    public void CreateCommand(IVipShoppingFactory factory)
    {
        var priority = factory.GetPriorite().Priority;
        var percentage = factory.GetReduction().Purcentage;
        
        Console.WriteLine("Priority Client = " + priority);
        Console.WriteLine("Purcentage = " + percentage);

    }
}