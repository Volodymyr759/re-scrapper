using Services;
using System;
using System.Collections.Generic;

namespace UI.Views.UserControls
{
    public interface IAgenciesUC
    {
        event EventHandler<AgencyDto> AgencyRowChanged;

        event EventHandler<string> ParseAgenciesOptionClicked;

        event EventHandler<string> ShowWebSiteOptionClicked;

        event EventHandler<string> ShowFacebookPageOptionClicked;

        void SetUpControls(IEnumerable<AgencyDto> agencyDtos);

        void UpdateControls(AgencyDto agencyDto);

        void UpdateStatus(string currentStatus);
    }
}
