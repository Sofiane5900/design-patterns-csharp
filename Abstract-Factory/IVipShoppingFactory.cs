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

public class StandardPurcentReduction : IPurcentReduction
{
    public decimal Purcentage => 0m;
}

public class VipPurcentReduction : IPurcentReduction
{
    public decimal Purcentage => 15m;
}
public interface IVipShoppingFactory
{
    IPurcentReduction GetReduction();
    IPriorityCommand GetPriorite();
}

public class VipShoppingFactory : IVipShoppingFactory
{
    public IPriorityCommand GetPriorite() => new VipPriorityCommand();

    public IPurcentReduction GetReduction() => new VipPurcentReduction();
}

public class StandardShoppingFactory : IVipShoppingFactory
{
    public IPriorityCommand GetPriorite() => new StandardPriorityCommand();

    public IPurcentReduction GetReduction() => new StandardPurcentReduction();
}