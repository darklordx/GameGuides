using GameGuides.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GameGuides.ViewViewModels.Guide
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GuidePage : ContentPage
    {
        ObservableCollection<GuideModel> models { get; set; }
        //int index { get; set; }

        //public GuidePage(ObservableCollection<GuideModel> src)
        //{
        //    InitializeComponent();
        //    BindingContext = new GuidePageViewModel();
        //    models = src;
        //    index = 0;
        //}
        public GuidePage(ObservableCollection<GuideModel> src, GuideModel prev)
        {
            InitializeComponent();
            BindingContext = new GuidePageViewModel(prev);
            models = src;
            //index = i;
        }
        //private async void SubmitButton_Onclicked(object sender, EventArgs e)
        //{
        //    EditListViewModel bc = BindingContext as EditListViewModel;
        //    models.Insert(index, new Person(
        //        bc.newName, bc.newImage, bc.newInfo
        //        ));
        //    await Navigation.PopAsync();
        //}
    }
}