namespace Users.Api.Models;

public class Visit
{
    public required DateTime DateOfVisit { get; set; }
    public required Animal Animal { get; set; }
    public required string Description { get; set; }
    public required int Price { get; set; }
}