using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FoodDrinkUIApp.Views
{
    public partial class MenuDetailPage : ContentPage
    {
        public MenuDetailPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.MenuDetailViewModel();
        }
    }
}
