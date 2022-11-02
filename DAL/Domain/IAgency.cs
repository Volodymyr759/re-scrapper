using System;

namespace DAL.Domain
{
    public interface IAgency
    {
        int Id { get; set; }
        string FacebookPage { get; set; }
        string FullAddress { get; set; }
        DateTime LastUpdatedOn { get; set; }
        Locality Locality { get; set; }
        int LocalityId { get; set; }
        string Logo { get; set; }
        string LogoBackgroundColor { get; set; }
        string Name { get; set; }
        string Notes { get; set; }
        string Phone { get; set; }
        int PropertiesForRent { get; set; }
        int PropertiesSold { get; set; }
        string WebSite { get; set; }
    }
}