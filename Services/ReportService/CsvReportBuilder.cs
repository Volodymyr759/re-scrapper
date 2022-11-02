using DAL.Domain;
using DAL.Repository;
using System.Text;

namespace Services.ReportService
{
    public class CsvReportBuilder : IReportBuilder
    {
        IRepository<Agency> _agencyRepository;

        IRepository<Locality> _localityRepository;

        public CsvReportBuilder(IRepository<Agency> agencyRepository, IRepository<Locality> localityRepository)
        {
            _agencyRepository = agencyRepository;
            _localityRepository = localityRepository;
        }

        public StringBuilder BuildAgenciesCsvReport()
        {
            var agencies = _agencyRepository.GetAll();

            var sb = new StringBuilder();
            sb.AppendLine("Id;Name;Address;Suburb;State;Postcode;Phone;ForRent;Sold;Web;Facebook;LogoBackgroundColor;Logo;Updated");

            foreach (var agency in agencies)
            {
                sb.AppendLine(
                        agency.Id + ";" + agency.Name + ";" + agency.FullAddress + ";" + agency.Locality.Suburb + ";" + agency.Locality.State + ";" +
                        agency.Locality.Postcode + ";" + agency.Phone + ";" + agency.PropertiesForRent + ";" + agency.PropertiesSold + ";" +
                        agency.WebSite + ";" + agency.FacebookPage + ";" + agency.LogoBackgroundColor + ";" + agency.Logo + ";" + agency.LastUpdatedOn.ToString()
                        );
            }

            return sb;
        }

        public StringBuilder BuildLocalitiesCsvReport()
        {
            var localities = _localityRepository.GetAll();

            var sb = new StringBuilder();
            sb.AppendLine("Id;Suburb;State;Postcode");

            foreach (var locality in localities)
            {
                sb.AppendLine(locality.Id + ";" + locality.Suburb + ";" + locality.State + ";" + locality.Postcode);
            }

            return sb;
        }
    }
}
