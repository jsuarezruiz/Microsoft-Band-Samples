namespace BandSample.Views
{
    using ViewModels;
    using Xamarin.Forms;

    public partial class TilesView : ContentPage
    {
        private object Parameter { get; set; }

        public TilesView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;
            BindingContext = App.Locator.TilesViewModel;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as TilesViewModel;
            if (viewModel != null) viewModel.OnAppearing(null);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as TilesViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}
