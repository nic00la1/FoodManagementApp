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
        private Dish _selectedDish;
        private readonly DishService _dishService;

        public ObservableCollection<Dish> Dishes => _dishService.Dishes;
        public Dish SelectedDish
        {
            get => _selectedDish;
            set
            {
                _selectedDish = value;
                OnPropertyChanged();
            }
        }

        public ICommand DishTappedCommand { get; }

        public MainPageViewModel()
        {
            _dishService = new DishService();
            DishTappedCommand = new Command<Dish>(OnDishTapped);
        }

        private async void OnDishTapped(Dish dish)
        {
            if (dish != null)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new EditDishPage(dish, _dishService));
                // Odśwież listę potraw po powrocie z ekranu edycji
                OnPropertyChanged(nameof(Dishes));
            }
        }
    }
}