namespace design_patterns.Singleton;

public sealed class Singleton
{
    private static Singleton _cache = new();
    public static Singleton Instance => _cache;

    private Singleton() { }
}
