using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DatabaseMsiTest
{
    public class WeatherContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        public WeatherContext(DbContextOptions<WeatherContext> options, IConfiguration configuration)
            : base(options)
        {
            if (configuration["Env"] == "Cloud")
            {
                var conn = (Microsoft.Data.SqlClient.SqlConnection)Database.GetDbConnection();
                conn.AccessToken = (new Microsoft.Azure.Services.AppAuthentication.AzureServiceTokenProvider()).GetAccessTokenAsync("https://database.windows.net/").Result;
            }

            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<WeatherForecast>().HasData(
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(0), TemperatureC = 10, Summary = "Freezing" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(1), TemperatureC = 20, Summary = "Bracing" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(2), TemperatureC = 30, Summary = "Chilly" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(3), TemperatureC = 40, Summary = "Cool" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(4), TemperatureC = 50, Summary = "Mild" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(5), TemperatureC = 60, Summary = "Warm" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(6), TemperatureC = 70, Summary = "Balmy" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(7), TemperatureC = 80, Summary = "Hot" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(8), TemperatureC = 90, Summary = "Sweltering" },
                new WeatherForecast { Id = Guid.NewGuid(), Date = DateTime.Now.AddDays(9), TemperatureC = 100, Summary = "Scorching" }
            );
        }
    }
}