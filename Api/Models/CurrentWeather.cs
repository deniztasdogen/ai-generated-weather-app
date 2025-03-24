namespace WeatherManagementAPI.Models;

public class CurrentWeather
{
    public int Id { get; set; }
    public int LocationId { get; set; }
    public double Temperature { get; set; }
    public double FeelsLike { get; set; }
    public double Humidity { get; set; }
    public double WindSpeed { get; set; }
    public string WindDirection { get; set; } = string.Empty;
    public double Pressure { get; set; }
    public double Precipitation { get; set; }
    public double CloudCover { get; set; }
    public double UvIndex { get; set; }
    public string Condition { get; set; } = string.Empty;
    public string ConditionDescription { get; set; } = string.Empty;
    public string ConditionIcon { get; set; } = string.Empty;
    public DateTime ObservationTime { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Navigation property
    public Location? Location { get; set; }
} 