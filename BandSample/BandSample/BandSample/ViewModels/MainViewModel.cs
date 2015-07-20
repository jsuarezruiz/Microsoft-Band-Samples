namespace BandSample.ViewModels
{
    using BandSample.Services.Navigation;
    using Base;
    using System.Windows.Input;

    public class MainViewModel : ViewModelBase
    {
        //Services
        private readonly INavigationService _navigationService;

        // Commands
        private ICommand _connectionCommand;
        private ICommand _sensorsCommand;
        private ICommand _tilesCommand;

        public MainViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand ConnectionCommand
        {
            get { return _connectionCommand = _connectionCommand ?? new DelegateCommand(ConnectionCommandExecute); }
        }

        public ICommand SensorsCommand
        {
            get { return _sensorsCommand = _sensorsCommand ?? new DelegateCommand(SensorsCommandExecute); }
        }

        public ICommand TilesCommand
        {
            get { return _tilesCommand = _tilesCommand ?? new DelegateCommand(TilesCommandExecute); }
        }

        private void ConnectionCommandExecute()
        {
            _navigationService.NavigateTo<ConnectionViewModel>();
        }

        private void SensorsCommandExecute()
        {
            _navigationService.NavigateTo<SensorsViewModel>();
        }

        private void TilesCommandExecute()
        {
            _navigationService.NavigateTo<TilesViewModel>();
        }
    }
}
