using Services.LocalityService;
using System;

namespace UI.Views.UserControls
{
    public interface ILocalityDetailsUC
    {
        event EventHandler<int> DeleteLocalityEventRaised;
        event EventHandler<LocalityDto> SaveLocalityEventRaised;

        void SetUpControls(LocalityDto localityDto);
    }
}
