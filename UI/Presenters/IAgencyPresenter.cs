using Services;
using UI.Views.UserControls;

namespace UI.Presenters
{
    public interface IAgencyPresenter
    {
        IAgenciesUC GetAgenciesUC();
        IAgencyDetailsUC GetAgencyDetailsUC(AgencyDto agencyDto = null);
    }
}
