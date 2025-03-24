namespace WeatherManagementAPI.Models;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string Region { get; set; } = string.Empty;
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string TimeZone { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    
    // Navigation property
    public ICollection<Forecast> Forecasts { get; set; } = new List<Forecast>();
    public ICollection<CurrentWeather> CurrentWeathers { get; set; } = new List<CurrentWeather>();
    public ICollection<WeatherAlert> WeatherAlerts { get; set; } = new List<WeatherAlert>();
} 