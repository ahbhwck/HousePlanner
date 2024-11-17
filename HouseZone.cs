namespace HouseManagement;

public class HouseZone
{
    public enum Size
    {
        Small,
        Normal,
        Big
    }

    public string Name { get; set; }
    public Size ZoneSize { get; set; }

    public HouseZone(string name, Size zoneSize)
    {
        Name = name;
        ZoneSize = zoneSize;
    }

    public override string ToString()
    {
        return $"HouseZone: {Name}, Size: {ZoneSize}";
    }
}