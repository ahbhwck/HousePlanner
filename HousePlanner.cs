namespace HouseManagement;

public class HousePlanner(List<Adult> adults, List<Child> children, List<HouseZone> zones)
{
    public HousePlan Plan()
    {
        var housePlan = new HousePlan();
        var pairs = GenerateAdultChildPairs();

        var random = new Random();

        var pairIndex = random.Next(pairs.Count);
        foreach (var zone in zones)
        {
            if (pairs.Count == 0) continue;
            
            var pair = pairs[pairIndex];
            housePlan.AddAssignment(new Assignment(zone, pair));
            pairIndex = (pairIndex + 1) % pairs.Count;
        }

        return housePlan;
    }

    private List<Pair> GenerateAdultChildPairs()
    {
        var random = new Random();
        var randomAdults = adults.OrderBy(_ => random.Next()).ToList();
        var randomChildren = children.OrderBy(_ => random.Next()).ToList();
        
        var pairs = new List<Pair>();
        var count = Math.Min(randomAdults.Count, randomChildren.Count);
        for (int i = 0; i < count; i++)
        {
            var pair = new Pair(randomAdults[i], randomChildren[i]);
            pairs.Add(pair);
        }

        return pairs;
    }
}

public record Pair(Adult adult, Child child);