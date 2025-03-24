namespace WeatherManagementAPI.Models;

public class ForecastDay
{
    public int Id { get; set; }
    public int ForecastId { get; set; }
    public DateTime Date { get; set; }
    public double MinTemperature { get; set; }
    public double MaxTemperature { get; set; }
    public double AvgTemperature { get; set; }
    public double WindSpeed { get; set; }
    public double Humidity { get; set; }
    public double Precipitation { get; set; }
    public double PrecipitationProbability { get; set; }
    public double CloudCover { get; set; }
    public double UvIndex { get; set; }
    public string Condition { get; set; } = string.Empty;
    public string ConditionDescription { get; set; } = string.Empty;
    public string ConditionIcon { get; set; } = string.Empty;
    public string SunriseTime { get; set; } = string.Empty;
    public string SunsetTime { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Navigation property
    public Forecast? Forecast { get; set; }
    public ICollection<ForecastHour> Hours { get; set; } = new List<ForecastHour>();
} 