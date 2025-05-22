// See https://aka.ms/new-console-template for more information


using design_patterns.Singleton;

// Singleton
Singleton instance1 = Singleton.Instance;
Singleton instance2 = Singleton.Instance;
Console.WriteLine(ReferenceEquals(instance1,instance2));