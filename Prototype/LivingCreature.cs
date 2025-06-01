namespace design_patterns.Prototype;

public abstract class LivingCreature
{
    public string Name { get; set; } = "";
    public abstract LivingCreature Clone();
}