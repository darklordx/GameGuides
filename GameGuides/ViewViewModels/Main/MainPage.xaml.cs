using GameGuides.Models;
using GameGuides.ViewViewModels.Guide;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameGuides.ViewViewModels.Main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<GuideModel> GameGuideModels { get; }
        public MainPage()
        {
            InitializeComponent();
            var viewModel = new MainPageViewModel();
            GameGuideModels = viewModel.GameGuides;
            BindingContext = viewModel;
        }
        private async void UpdateButton_OnClicked(object sender, EventArgs e)
        {
            Button view = sender as Button;
            var item = view.BindingContext as GuideModel;
            await Navigation.PushAsync(new GuidePage(GameGuideModels, item));
        }
    }
}