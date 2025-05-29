namespace design_patterns.Abstract_Factory;

public interface IPriorityCommand
{
    int Priority { get;}
}
public interface IPercentReduction
{
    decimal Percentage { get; }
}

public class StandardPriorityCommand : IPriorityCommand
{
    public int Priority => 0;
}

public class VipPriorityCommand : IPriorityCommand
{
    public int Priority => 1;
}

public class StandardPercentReduction : IPercentReduction
{
    public decimal Percentage => 0m;
}

public class VipPercentReduction : IPercentReduction
{
    public decimal Percentage => 15m;
}
public interface IVipShoppingFactory
{
    IPercentReduction GetReduction();
    IPriorityCommand GetPriorite();
}

public class VipShoppingFactory : IVipShoppingFactory
{
    public IPriorityCommand GetPriorite() => new VipPriorityCommand();

    public IPercentReduction GetReduction() => new VipPercentReduction();
}

public class StandardShoppingFactory : IVipShoppingFactory
{
    public IPriorityCommand GetPriorite() => new StandardPriorityCommand();

    public IPercentReduction GetReduction() => new StandardPercentReduction();
}