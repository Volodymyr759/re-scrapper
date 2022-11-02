using Services.AgencyService;
using Services.LocalityService;
using System.Collections.Generic;

namespace Services.AgencyParseService
{
    public interface IAgencyParser
    {
        IEnumerable<ParseAgencyDto> ParseAgenciesFromRE(IEnumerable<LocalityDto> localityDtos);
    }
}
