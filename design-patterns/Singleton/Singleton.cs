namespace design_patterns.Singleton;

public sealed class Singleton
{
    private static Lazy<Singleton> _instance = new(() => new Singleton());
    public static Singleton Instance => _instance.Value;

    private Singleton() { }
}
