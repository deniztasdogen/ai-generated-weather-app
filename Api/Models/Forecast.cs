namespace WeatherManagementAPI.Models;

public class Forecast
{
    public int Id { get; set; }
    public int LocationId { get; set; }
    public DateTime ForecastDate { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Navigation properties
    public Location? Location { get; set; }
    public ICollection<ForecastDay> Days { get; set; } = new List<ForecastDay>();
} 