using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Domain
{
    public class Agency : IAgency
    {
        public Agency()
        {
            LastUpdatedOn = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Maximum length of agency name should be less than 300 characters")]
        public string Name { get; set; }

        [Required]
        [MaxLength(300, ErrorMessage = "Maximum length of agency full address should be less than 300 characters")]
        public string FullAddress { get; set; }

        public virtual Locality Locality { get; set; }

        [Required(ErrorMessage = "Required to choose locality")]
        public int LocalityId { get; set; }

        public string Logo { get; set; }

        public string LogoBackgroundColor { get; set; }

        public string WebSite { get; set; }

        public string FacebookPage { get; set; }

        public int PropertiesSold { get; set; }

        public int PropertiesForRent { get; set; }

        public string Phone { get; set; }

        public string Notes { get; set; }

        [Required]
        [Display(Name = "Updated")]
        public DateTime LastUpdatedOn { get; set; }
    }
}
