using Services.LocalityService;
using System;
using System.Collections.Generic;

namespace UI.Views.UserControls
{
    public interface ILocalitiesUC
    {
        event EventHandler<LocalityDto> LocalityRowChanged;

        void UpdateControls(LocalityDto localityDto);
        void SetUpControls(IEnumerable<LocalityDto> localityDtos);
    }
}
