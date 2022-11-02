using System;
using System.ComponentModel.DataAnnotations;

namespace Services
{
    public class AgencyDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Maximum length of agency name should be less than 300 characters")]
        public string Name { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Maximum length of agency full address should be less than 300 characters")]
        public string FullAddress { get; set; }

        public string State { get; set; }

        public string WebSite { get; set; }

        public string FacebookPage { get; set; }

        public int PropertiesSold { get; set; }

        public int PropertiesForRent { get; set; }

        public string Phone { get; set; }

        [Required]
        [Display(Name = "Updated")]
        public DateTime LastUpdatedOn { get; set; }

        public string Notes { get; set; }
    }
}
