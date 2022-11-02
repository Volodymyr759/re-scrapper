using Services.LocalityService;
using UI.Views.UserControls;

namespace UI.Presenters
{
    public interface ILocalityPresenter
    {
        ILocalitiesUC GetLocalitiesUC();
        ILocalityDetailsUC GetLocalityDetailsUC(LocalityDto localityDto = null);
    }
}
