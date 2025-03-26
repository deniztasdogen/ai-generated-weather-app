using Microsoft.EntityFrameworkCore;
using WeatherManagementAPI.Models;

namespace WeatherManagementAPI.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSets for all domain models
    public DbSet<Location> Locations { get; set; } = null!;
    public DbSet<CurrentWeather> CurrentWeathers { get; set; } = null!;
    public DbSet<Forecast> Forecasts { get; set; } = null!;
    public DbSet<ForecastDay> ForecastDays { get; set; } = null!;
    public DbSet<ForecastHour> ForecastHours { get; set; } = null!;
    public DbSet<WeatherAlert> WeatherAlerts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Location entity
        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Country).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Region).HasMaxLength(100);
            entity.Property(e => e.TimeZone).HasMaxLength(50);
        });

        // Configure CurrentWeather entity
        modelBuilder.Entity<CurrentWeather>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.Location)
                  .WithMany(l => l.CurrentWeathers)
                  .HasForeignKey(e => e.LocationId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure Forecast entity
        modelBuilder.Entity<Forecast>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.Location)
                  .WithMany(l => l.Forecasts)
                  .HasForeignKey(e => e.LocationId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure ForecastDay entity
        modelBuilder.Entity<ForecastDay>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.Forecast)
                  .WithMany(f => f.Days)
                  .HasForeignKey(e => e.ForecastId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure ForecastHour entity
        modelBuilder.Entity<ForecastHour>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.HasOne(e => e.ForecastDay)
                  .WithMany(f => f.Hours)
                  .HasForeignKey(e => e.ForecastDayId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        // Configure WeatherAlert entity
        modelBuilder.Entity<WeatherAlert>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Title).IsRequired().HasMaxLength(200);
            entity.Property(e => e.Severity).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Type).IsRequired().HasMaxLength(50);
            entity.HasOne(e => e.Location)
                  .WithMany(l => l.WeatherAlerts)
                  .HasForeignKey(e => e.LocationId)
                  .OnDelete(DeleteBehavior.Cascade);
        });
    }
} 