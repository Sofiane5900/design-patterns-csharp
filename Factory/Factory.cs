namespace design_patterns.Factory;

public abstract class Factory
{
    public abstract void CreateProduct();
}

public class FactoryImplementationOne : Factory
{
    public override void CreateProduct()
    {
       Console.WriteLine("1");
    }
}

public class FactoryImplementationTwo : Factory
{
    public override void CreateProduct()
    {
        Console.WriteLine("2");
    }
}

public class FactoryImplementationThree : Factory
{
    public override void CreateProduct()
    {
        Console.WriteLine("3");
    }
}