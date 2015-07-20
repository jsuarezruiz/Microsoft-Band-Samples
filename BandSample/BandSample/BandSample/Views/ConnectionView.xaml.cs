namespace BandSample.Views
{
    using ViewModels;
    using Xamarin.Forms;

    public partial class ConnectionView : ContentPage
    {
        private object Parameter { get; set; }

        public ConnectionView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;
            BindingContext = App.Locator.ConnectionViewModel;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as ConnectionViewModel;
            if (viewModel != null) viewModel.OnAppearing(null);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as ConnectionViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}
