namespace HouseManagement;

public class HouseMember
{
    public enum AgeGroup
    {
        Child,
        Adult
    }

    public string Name { get; set; }
    public AgeGroup AgeCategory { get; set; }

    public HouseMember(string name, AgeGroup ageCategory)
    {
        Name = name;
        AgeCategory = ageCategory;
    }

    public override string ToString()
    {
        return $"HouseMember: {Name}, Age Group: {AgeCategory}";
    }
}

public class Adult(string name) : HouseMember(name, AgeGroup.Adult);

public class Child(string name) : HouseMember(name, AgeGroup.Child);