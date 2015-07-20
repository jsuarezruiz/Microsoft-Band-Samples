
using Xamarin.Forms;

namespace BandSample.Views
{
    public partial class SensorsView : ContentPage
    {
        public SensorsView()
        {
            InitializeComponent();

            BindingContext = App.Locator.SensorsViewModel;
        }
    }
}
