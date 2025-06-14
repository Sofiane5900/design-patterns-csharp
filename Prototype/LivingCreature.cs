namespace design_patterns.Prototype;

public abstract class LivingCreature
{
    public string Name { get; set; } = "";
    public abstract LivingCreature Clone(bool deepclone);
}

public class Dog : LivingCreature
{
    public Person Owner { get; set; } 

    public Dog(string name, Person owner)
    {
        Name = name;
        Owner = owner;
    }
    


    public override LivingCreature Clone(bool deepClone = false)
    {
        if (deepClone)
        {
            var dog = (Dog)MemberwiseClone();
            dog.Owner = (Person)Owner.Clone(true);
            return dog;
        }
        return (LivingCreature)MemberwiseClone();
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