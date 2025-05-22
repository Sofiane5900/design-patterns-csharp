namespace design_patterns.Singleton;

public sealed class MemoryCache
{
    private static MemoryCache _cache = new();
    public static MemoryCache Instance => _cache;
    private MemoryCache()
    {
        
    }
}