namespace design_patterns.Singleton;

public sealed class Singleton
{
    private static Singleton _instance = new();
    public static Singleton Instance => _instance;

    private Singleton() { }
}
