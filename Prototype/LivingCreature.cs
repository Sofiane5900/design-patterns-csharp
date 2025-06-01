namespace design_patterns.Prototype;

public abstract class LivingCreature
{
    public string Name { get; set; } = "";
    public abstract LivingCreature Clone();
}

public class Dog : LivingCreature
{
    public Dog(string name)
    {
        Name = name;
    }
    public override LivingCreature Clone()
    {
        throw new NotImplementedException();
    }
}