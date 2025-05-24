namespace design_patterns.Factory;

public abstract class Factory
{
    public abstract void CreateProduct();
}

public class FactoryImplementation : Factory
{
    public override void CreateProduct()
    {
       Console.WriteLine("Factory Pattern");
    }
}