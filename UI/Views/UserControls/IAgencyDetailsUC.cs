using Services;
using System;

namespace UI.Views.UserControls
{
    public interface IAgencyDetailsUC
    {
        event EventHandler<int> DeleteAgencyEventRaised;
        event EventHandler<AgencyDto> SaveAgencyEventRaised;

        void SetUpControls(AgencyDto agencyDto);
    }
}