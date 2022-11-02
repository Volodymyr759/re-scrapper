using AutoMapper;
using DAL.Domain;
using DAL.Repository;
using DataAccess;
using Services;
using Services.AgencyService;
using Services.LocalityService;
using System;
using System.Data.Entity;
using System.Windows.Forms;
using UI.Presenters;
using UI.Views;
using UI.Views.UserControls;
using Unity;
using Unity.Lifetime;

namespace UI
{
    static class Program
    {
        public static IUnityContainer UnityC;

        [STAThread]
        static void Main()
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.AddProfile(new AutoMapperProfile()));

                UnityC = new UnityContainer()
                        /*Models*/
                        .RegisterType<IAgency, Agency>(new ContainerControlledLifetimeManager())
                        .RegisterType<ILocality, Locality>(new ContainerControlledLifetimeManager())
                        /*Repository*/
                        .RegisterType<DbContext, ReScraperContext>(new ContainerControlledLifetimeManager())
                        .RegisterType(typeof(IRepository<>), typeof(EFRepository<>), new ContainerControlledLifetimeManager())
                        /*Presenters*/
                        .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())
                        .RegisterType<IAgencyPresenter, AgencyPresenter>(new ContainerControlledLifetimeManager())
                        .RegisterType<ILocalityPresenter, LocalityPresenter>(new ContainerControlledLifetimeManager())
                        .RegisterType<ISettingsPresenter, SettingsPresenter>(new ContainerControlledLifetimeManager())
                        /*Services*/
                        .RegisterType<IAgencyService, AgencyService>(new ContainerControlledLifetimeManager())
                        .RegisterType<ILocalityService, LocalityService>(new ContainerControlledLifetimeManager())
                        /*Views*/
                        .RegisterType<IMainView, MainView>()
                        .RegisterType<IErrorMessageView, ErrorMessageView>()
                        .RegisterType<IDeleteConfirmView, DeleteConfirmView>()
                        .RegisterType<IAgenciesUC, AgenciesUC>(new ContainerControlledLifetimeManager())
                        .RegisterType<IAgencyDetailsUC, AgencyDetailsUC>(new ContainerControlledLifetimeManager())
                        .RegisterType<ILocalitiesUC, LocalitiesUC>(new ContainerControlledLifetimeManager())
                        .RegisterType<ILocalityDetailsUC, LocalityDetailsUC>(new ContainerControlledLifetimeManager())
                        .RegisterType<ISettingsUC, SettingsUC>(new ContainerControlledLifetimeManager())
                        /*AutoMapper*/
                        .RegisterInstance(config.CreateMapper(), new ContainerControlledLifetimeManager());

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                IMainPresenter mainPresenter = UnityC.Resolve<MainPresenter>();
                IMainView mainView = mainPresenter.GetMainView();

                Application.Run((MainView)mainView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
