using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.LocalityService
{
    public interface ILocalityService
    {
        bool CreateLocality(LocalityDto agencyDto);
        void DeleteLocality(int id);
        void DeleteLocalityAsync(int id);
        IEnumerable<LocalityDto> GetAllLocalities();
        LocalityDto GetLocalityById(int id);
        Task<LocalityDto> GetLocalityByIdAsync(int id);
        LocalityDto UpdateLocality(LocalityDto localityDto);
        Task<LocalityDto> UpdateLocalityAsync(LocalityDto localityDto);
    }
}
