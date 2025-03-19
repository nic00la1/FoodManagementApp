using System.Collections.ObjectModel;
using System.Windows.Input;
using FoodManagementApp.MVVM.Model;
using FoodManagementApp.MVVM.View;
using FoodManagementApp.Services;
using Microsoft.Maui.Controls;

namespace FoodManagementApp.MVVM.ViewModel
{
    public class MainPageViewModel : BindableObject
    {
        public ObservableCollection<Dish> Dishes { get; set; }
        public Command ShowDetailedCmd { get; }

        private readonly INavigation _navigation;
        private readonly DishService _dataService;

        public MainPageViewModel(DishService dataService, INavigation navigation)
        {
            _navigation = navigation;
            _dataService = dataService;

            Dishes = _dataService.Dishes;

            ShowDetailedCmd = new Command<Dish>(OnDishTapped);
        }

        private async void OnDishTapped(Dish dish)
        {
            if (dish != null)
            {
                if (dish != null)
                    await _navigation.PushAsync(new EditDishPage(dish));
            }
        }
    }
}