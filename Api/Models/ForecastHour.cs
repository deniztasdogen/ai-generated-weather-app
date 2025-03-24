namespace WeatherManagementAPI.Models;

public class ForecastHour
{
    public int Id { get; set; }
    public int ForecastDayId { get; set; }
    public DateTime Time { get; set; }
    public double Temperature { get; set; }
    public double FeelsLike { get; set; }
    public double WindSpeed { get; set; }
    public string WindDirection { get; set; } = string.Empty;
    public double Humidity { get; set; }
    public double Precipitation { get; set; }
    public double PrecipitationProbability { get; set; }
    public double CloudCover { get; set; }
    public double Pressure { get; set; }
    public double Visibility { get; set; }
    public double UvIndex { get; set; }
    public string Condition { get; set; } = string.Empty;
    public string ConditionDescription { get; set; } = string.Empty;
    public string ConditionIcon { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    
    // Navigation property
    public ForecastDay? ForecastDay { get; set; }
} 