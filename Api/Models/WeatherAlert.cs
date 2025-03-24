namespace WeatherManagementAPI.Models;

public class WeatherAlert
{
    public int Id { get; set; }
    public int LocationId { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Severity { get; set; } = string.Empty;  // Low, Moderate, High, Extreme
    public string Type { get; set; } = string.Empty;      // Storm, Flood, Hurricane, etc.
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    
    // Navigation property
    public Location? Location { get; set; }
} 