using System;
using System.Collections.ObjectModel;
using FoodDrinkUIApp.Models;

namespace FoodDrinkUIApp.ViewModels
{
    public class MenuDetailViewModel
    {
        public ObservableCollection<Menu> menu { get; set; }

        public MenuDetailViewModel()
        {
            menu = new ObservableCollection<Menu>()
            {
               new Menu  { Name="Peanut Butter", Icon = "Peanut" },
               new Menu  { Name="Cherry",        Icon = "Cherry" },
               new Menu  { Name="Straw Berry",   Icon = "StrawBerry" },
               new Menu  { Name="Chocolate",     Icon = "Chocolate" } 
            };
        }
    }
}
