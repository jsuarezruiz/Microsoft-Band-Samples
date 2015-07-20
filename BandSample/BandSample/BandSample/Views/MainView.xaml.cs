namespace BandSample.Views
{
    using BandSample.ViewModels;
    using Xamarin.Forms;

    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();

            BindingContext = App.Locator.MainViewModel;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as MainViewModel;
            if (viewModel != null) viewModel.OnAppearing(null);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as MainViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}
