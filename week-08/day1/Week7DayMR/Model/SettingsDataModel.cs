using System.ComponentModel.DataAnnotations;

namespace Week7DayMR
{
    public class SettingsDataModel // Settings database table representational model; each property represents one column
    {
        [Key]
        public string Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [MaxLength(2048)]
        public string Value { get; set; }
    }
}
