using System.Text;

namespace HouseManagement;

public class HousePlan
{
    private readonly Dictionary<HouseZone, Pair> _zoneMappings;
    private readonly List<Assignment> _assignments;

    public HousePlan()
    {
        _zoneMappings = new Dictionary<HouseZone, Pair>();
        _assignments = new List<Assignment>();
    }

    public void AddAssignment(Assignment assignment)
    {
        _assignments.Add(assignment);
    }

    public class MemberAssignment
    {
        public string MemberName { get; set; }
        public string Assignment { get; set; }
    }
    
    public string DisplayAssignmentsByMember()
    {
        var sb = new StringBuilder();

        sb.AppendLine("<html>");
        sb.AppendLine("<head>");
        sb.AppendLine("<title>House Plan Assignments</title>");
        sb.AppendLine("</head>");
        sb.AppendLine("<body>");
        sb.AppendLine($"<h1>{DateTime.Now.Month}/{DateTime.Today.Date.Day} Assignments</h1>");
        sb.AppendLine("<table border='1'>");
        sb.AppendLine("<tr><th>Member Name</th><th>Member Name</th><th>Assignment</th></tr>");

        foreach (var assignment in _assignments)
        {
            sb.AppendLine($"<tr><td>{assignment.memberPair.adult.Name}</td><td>{assignment.memberPair.child.Name}</td><td>{assignment.zone.Name}</td></tr>");
        }

        sb.AppendLine("</table>");
        sb.AppendLine("</body>");
        sb.AppendLine("</html>");

        return sb.ToString();
    }

    public void SaveAssignmentsToHtml(string filePath)
    {
        string htmlContent = DisplayAssignmentsByMember();
        File.WriteAllText(filePath, htmlContent);
    }
}

public record Assignment(HouseZone zone, Pair memberPair);