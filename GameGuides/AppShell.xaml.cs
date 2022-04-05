using System;
using System.Collections.Generic;
using GameGuides.ViewModels;
using GameGuides.Views;
using Xamarin.Forms;

namespace GameGuides
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
