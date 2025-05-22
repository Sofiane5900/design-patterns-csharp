namespace design_patterns.Singleton;

public sealed class MemoryCache
{
    public static MemoryCache Instance { get; set; }
    private MemoryCache()
    {
        
    }
}