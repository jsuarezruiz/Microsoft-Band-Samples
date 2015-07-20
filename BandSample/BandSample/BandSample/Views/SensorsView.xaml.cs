
namespace BandSample.Views
{
    using ViewModels;
    using Xamarin.Forms;

    public partial class SensorsView : TabbedPage
    {
        private object Parameter { get; set; }

        public SensorsView(object parameter)
        {
            InitializeComponent();

            Parameter = parameter;
            BindingContext = App.Locator.SensorsViewModel;
        }

        protected override void OnAppearing()
        {
            var viewModel = BindingContext as SensorsViewModel;
            if (viewModel != null) viewModel.OnAppearing(null);
        }

        protected override void OnDisappearing()
        {
            var viewModel = BindingContext as SensorsViewModel;
            if (viewModel != null) viewModel.OnDisappearing();
        }
    }
}
