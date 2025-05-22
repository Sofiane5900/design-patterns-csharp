namespace design_patterns.Singleton;

public sealed class Singleton
{
    // Using Lazy to not instantiate the object if not used
    private static Lazy<Singleton> _instance = new(() => new Singleton());
    
    // Global access point to the unique Singleton instance 
    public static Singleton Instance => _instance.Value;

    // Constructor private so the Singleton to prevent external instantiation
    private Singleton() { }
}
