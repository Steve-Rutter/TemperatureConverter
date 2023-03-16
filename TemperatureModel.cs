using System.ComponentModel.DataAnnotations;

namespace TempConverter
{
    public class TemperatureModel
    {
        [Required]
        public double TemperatureValue { get; set; }
        [Required]
        public string? SourceTemperatureType { get; set; }
        [Required]
        public string? TargetTemperatureType { get; set; }
    }
}
