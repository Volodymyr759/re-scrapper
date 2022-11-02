using AutoMapper;
using DAL.Domain;
using DAL.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.AgencyService
{
    public class AgencyService : IAgencyService
    {
        #region Members

        readonly IRepository<Agency> _agencyRepository;

        IMapper _mapper;

        #endregion

        #region Ctor

        public AgencyService(IRepository<Agency> agencyRepository, IMapper mapper)
        {
            _agencyRepository = agencyRepository;
            _mapper = mapper;
        }

        #endregion

        public void CreateAgency(ParseAgencyDto parseAgencyDto)
        {
            bool canCreate = _agencyRepository.GetAll(a => a.Name == parseAgencyDto.Name
                    && a.FullAddress == parseAgencyDto.FullAddress).Count() == 0;
            if (canCreate)
            {
                var agency = _mapper.Map<Agency>(parseAgencyDto);
                _agencyRepository.Create(agency);
            }
        }

        public async void DeleteAgencyAsync(int id)
        {
            var agency = await _agencyRepository.GetAsync(id);
            if (agency != null) await Task.Run(() => _agencyRepository.DeleteAsync(agency));
        }

        public async Task<AgencyDto> GetAgencyByIdAsync(int id)
        {
            var agency = await _agencyRepository.GetAsync(id);
            return _mapper.Map<AgencyDto>(agency);
        }

        public AgencyDto GetAgencyById(int id) => _mapper.Map<AgencyDto>(_agencyRepository.Get(id));

        public IEnumerable<AgencyDto> GetAllAgencies() => _mapper.Map<IEnumerable<AgencyDto>>(_agencyRepository.GetAll());

        public async Task<AgencyDto> UpdateAgencyAsync(AgencyDto agencyDto)
        {
            var agencyFromDb = await _agencyRepository.GetAsync(agencyDto.Id);
            if (agencyFromDb != null)
            {
                agencyFromDb.Name = agencyDto.Name;
                agencyFromDb.FullAddress = agencyDto.FullAddress;
                agencyFromDb.WebSite = agencyDto.WebSite;
                agencyFromDb.FacebookPage = agencyDto.FacebookPage;
                agencyFromDb.Phone = agencyDto.Phone;
                agencyFromDb.Notes = agencyDto.Notes;
                agencyFromDb.LastUpdatedOn = agencyDto.LastUpdatedOn;

                await Task.Run(() => _agencyRepository.UpdateAsync(agencyFromDb));
            }
            return _mapper.Map<AgencyDto>(agencyFromDb);
        }
    }
}
