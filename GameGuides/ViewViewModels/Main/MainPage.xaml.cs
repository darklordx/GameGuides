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
            GameGuideModels = viewModel.RealGameGuides;
            BindingContext = viewModel;
        }
        private async void UpdateButton_OnClicked(object sender, EventArgs e)
        {
            Button view = sender as Button;
            var item = view.BindingContext as GuideModel;
            //int index = GameGuideModels.IndexOf(item);
            //GameGuideModels.Remove(item);
            await Navigation.PushAsync(new GuidePage(GameGuideModels, item)); // Send a reference to the models.

            //Debug.WriteLine(view.ToString());
            //string newName = await DisplayPromptAsync("Change Name", "New Name?", initialValue: item.Name);
            //string newInfo = await DisplayPromptAsync("Change Info", "New Info?", initialValue: item.Info);
            //string newImage = await DisplayPromptAsync("Change Image", "New Image?", initialValue: item.srcstring);

            //models.Insert(index, new Person(newName, newImage, newInfo));
        }
    }
}