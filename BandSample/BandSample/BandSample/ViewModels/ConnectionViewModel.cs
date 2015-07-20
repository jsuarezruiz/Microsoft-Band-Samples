namespace BandSample.ViewModels
{
    using Service.Connection;
    using Base;
    using System.Windows.Input;

    public class ConnectionViewModel : ViewModelBase
    {
        // Services
        private IConnectionService _connectionService;

        // Commands
        private ICommand _connectCommand;

        public ConnectionViewModel(IConnectionService connectionService)
        {
            _connectionService = connectionService;
        }

        public ICommand ConnectCommand
        {
            get { return _connectCommand = _connectCommand ?? new DelegateCommand(ConnectCommandExecute); }
        }

        private async void ConnectCommandExecute()
        {
            var result = await _connectionService.Pair();
        }
    }
}
