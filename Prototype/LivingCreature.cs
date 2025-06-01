namespace design_patterns.Prototype;

public abstract class LivingCreature
{
    public string Name { get; set; } = "";
    public abstract LivingCreature Clone(bool deepclone);
}

public class Dog : LivingCreature
{
    public Person Owner { get; private set; } 

    public Dog(string name, Person owner)
    {
        Name = name;
        Owner = owner;
    }


    public override LivingCreature Clone(bool deepclone = false)
    {
        throw new NotImplementedException();
    }
}

public class Person : LivingCreature
{
    public Person(string name)
    {
        Name = name;
    }

    public override LivingCreature Clone(bool deepClone = false)
    {
        return (LivingCreature)MemberwiseClone();
    }
}