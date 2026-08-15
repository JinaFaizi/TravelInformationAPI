namespace TravelInformationAPI.Models;

public class Country
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Capital { get; set; }

    public List<PointOfInterest> PointOfInterests { get; set; } = new();
}