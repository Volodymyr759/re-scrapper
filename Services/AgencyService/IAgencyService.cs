using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.AgencyService
{
    public interface IAgencyService
    {
        void CreateAgency(ParseAgencyDto parseAgencyDto);
        void DeleteAgencyAsync(int id);
        IEnumerable<AgencyDto> GetAllAgencies();
        AgencyDto GetAgencyById(int id);
        Task<AgencyDto> GetAgencyByIdAsync(int id);
        Task<AgencyDto> UpdateAgencyAsync(AgencyDto agencyDto);
    }
}
