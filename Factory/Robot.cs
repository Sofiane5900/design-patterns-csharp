namespace design_patterns.Factory;

public abstract class RobotBuilder
{
    public abstract void CreateProduct();
}

public class TypeOneRobot : RobotBuilder
{
    public override void CreateProduct()
    {
        Console.WriteLine("Fabricating a type one robot... Created !");
    }
}

public class TypeTwoRobot : RobotBuilder
{
    public override void CreateProduct()
    {
        Console.WriteLine("Fabricating a type two robot... Created !");
    }
}

public class TypeThreeRobot : RobotBuilder
{
    public override void CreateProduct()
    {
        Console.WriteLine("Fabricating a type three robot... Created !");
    }
}