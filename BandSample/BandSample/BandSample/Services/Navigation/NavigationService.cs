namespace BandSample.Services.Navigation
{
    using System;
    using System.Collections.Generic;
    using ViewModels;
    using Views;
    using Xamarin.Forms;

    public class NavigationService : INavigationService
    {
        /// <summary>
        /// 
        /// </summary>
        private IDictionary<Type, Type> viewModelRouting = new Dictionary<Type, Type>()
        {
            { typeof(MainViewModel), typeof(MainView) },
            { typeof(ConnectionViewModel), typeof(ConnectionView) },     
            { typeof(SensorsViewModel), typeof(SensorsView) },
            { typeof(TilesViewModel), typeof(TilesView) }
        };

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TDestinationViewModel"></typeparam>
        /// <param name="navigationContext"></param>
        public void NavigateTo<TDestinationViewModel>(object navigationContext = null)
        {
            Type pageType = viewModelRouting[typeof(TDestinationViewModel)];
            var page = Activator.CreateInstance(pageType, navigationContext) as Page;
            Application.Current.MainPage.Navigation.PushAsync(page);
        }

        /// <summary>
        /// 
        /// </summary>
        public void NavigateBack()
        {
            Application.Current.MainPage.Navigation.PopAsync();
        }

        /// <summary>
        /// 
        /// </summary>
        public void NavigateBackToFirst()
        {
            Application.Current.MainPage.Navigation.PopToRootAsync();
        }
    }
}