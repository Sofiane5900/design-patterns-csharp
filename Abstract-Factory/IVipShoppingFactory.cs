namespace design_patterns.Abstract_Factory;

public interface IPriorityCommand
{
    int Priority { get;}
}
public interface IPurcentReduction
{
    decimal Purcentage { get; }
}

public class StandardPriorityCommand : IPriorityCommand
{
    public int Priority => 0;
}

public class VipPriorityCommand : IPriorityCommand
{
    public int Priority => 1;
}


public interface IVipShoppingFactory
{
    
}