using System.ComponentModel.DataAnnotations;

namespace Services.LocalityService
{
    public class LocalityDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Maximum length of state should be less than 20 characters")]
        public string State { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Maximum length of suburb name should be less than 300 characters")]
        public string Suburb { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Maximum length of postcode should be less than 20 characters")]
        public string Postcode { get; set; }
    }
}
