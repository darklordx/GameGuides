using System.ComponentModel;
using Xamarin.Forms;
using GameGuides.ViewModels;

namespace GameGuides.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}