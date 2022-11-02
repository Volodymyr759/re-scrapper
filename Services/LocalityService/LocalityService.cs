using AutoMapper;
using DAL.Domain;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.LocalityService
{
    public class LocalityService : ILocalityService
    {
        #region Members

        IMapper _mapper;
        readonly IRepository<Locality> _localityRepository;

        #endregion

        #region Ctor

        public LocalityService(IRepository<Locality> localityRepository, IMapper mapper)
        {
            _localityRepository = localityRepository;
            _mapper = mapper;
        }

        #endregion

        public bool CreateLocality(LocalityDto agencyDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteLocality(int id)
        {
            var locality = _localityRepository.Get(id);
            if (locality != null) _localityRepository.Delete(locality);
        }

        public async void DeleteLocalityAsync(int id)
        {
            var locality = await _localityRepository.GetAsync(id);
            if (locality != null) await Task.Run(() => _localityRepository.DeleteAsync(locality));
        }

        public IEnumerable<LocalityDto> GetAllLocalities() => _mapper.Map<IEnumerable<LocalityDto>>(_localityRepository.GetAll());

        public LocalityDto GetLocalityById(int id) => _mapper.Map<LocalityDto>(_localityRepository.Get(id));

        public async Task<LocalityDto> GetLocalityByIdAsync(int id)
        {
            var locality = await _localityRepository.GetAsync(id);
            return _mapper.Map<LocalityDto>(locality);
        }

        public LocalityDto UpdateLocality(LocalityDto localityDto)
        {
            var localityFromDb = _localityRepository.Get(localityDto.Id);

            if (localityFromDb != null)
            {
                localityFromDb.Postcode = localityDto.Postcode;
                localityFromDb.State = localityDto.State;
                localityFromDb.Suburb = localityDto.Suburb;

                _localityRepository.Update(localityFromDb);
            }

            return _mapper.Map<LocalityDto>(localityFromDb);
        }

        public async Task<LocalityDto> UpdateLocalityAsync(LocalityDto localityDto)
        {
            var localityFromDb = await _localityRepository.GetAsync(localityDto.Id);

            if (localityFromDb != null)
            {
                localityFromDb.Postcode = localityDto.Postcode;
                localityFromDb.State = localityDto.State;
                localityFromDb.Suburb = localityDto.Suburb;

                await Task.Run(() => _localityRepository.UpdateAsync(localityFromDb));
            }

            return _mapper.Map<LocalityDto>(localityFromDb);
        }
    }
}
