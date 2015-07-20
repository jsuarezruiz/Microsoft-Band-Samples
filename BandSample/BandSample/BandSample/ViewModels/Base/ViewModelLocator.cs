namespace BandSample.ViewModels.Base
{
    using Service.Connection;
    using Microsoft.Practices.Unity;
    using ViewModels;
    using Xamarin.Forms;

    public class ViewModelLocator
    {
        readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            // ViewModels
            _container.RegisterType<MainViewModel>();
            _container.RegisterType<ConnectionViewModel>();
            _container.RegisterType<SensorsViewModel>();
            _container.RegisterType<TilesViewModel>();

            // Services
            _container.RegisterType<IConnectionService, ConnectionService>();
        }

        public MainViewModel MainViewModel
        {
            get { return _container.Resolve<MainViewModel>(); }
        }

        public ConnectionViewModel ConnectionViewModel
        {
            get { return _container.Resolve<ConnectionViewModel>(); }
        }

        public SensorsViewModel SensorsViewModel
        {
            get { return _container.Resolve<SensorsViewModel>(); }
        }

        public TilesViewModel TilesViewModel
        {
            get { return _container.Resolve<TilesViewModel>(); }
        }
    }
}
