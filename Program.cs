using HouseManagement;

List<HouseZone> zones =
[
    new("Living Room", HouseZone.Size.Big),
    new("Kitchen", HouseZone.Size.Normal),
    new("Upstairs Bathroom", HouseZone.Size.Small),
    new("Downstairs Bathroom", HouseZone.Size.Small),
    new("Dining Room", HouseZone.Size.Normal),
    new("Garage", HouseZone.Size.Big),
];

// Create house members
List<Adult> adults =
[
    new("Rebekah"),
    new("Adam"),
    new("Josh")
];
List<Child> children =
[
    new("Wes"),
    new("Charlie"),
    new("Katherine")
];

// Create house planner
HousePlanner planner = new HousePlanner(adults, children, zones);

// Generate house plan
HousePlan housePlan = planner.Plan();

// Display the house plan
string filePath = "housePlanAssignments.html";
housePlan.SaveAssignmentsToHtml(filePath);

Console.WriteLine($"HTML file with assignments saved to {filePath}");