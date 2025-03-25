namespace WeatherManagementAPI.Models;

public class UserPreference
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string PreferenceKey { get; set; } = string.Empty;  // e.g., "TemperatureUnit", "Theme"
    public string PreferenceValue { get; set; } = string.Empty; // e.g., "Celsius", "Dark"
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    
    // Navigation property
    public User? User { get; set; }
} 