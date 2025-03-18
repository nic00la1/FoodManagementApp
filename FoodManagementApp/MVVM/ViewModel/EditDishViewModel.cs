using System.Windows.Input;
using FoodManagementApp.MVVM.Model;
using FoodManagementApp.Services;
using Microsoft.Maui.Controls;

namespace FoodManagementApp.MVVM.ViewModel
{
    public class EditDishViewModel : BindableObject
    {
        private Dish _dish;
        private readonly DishService _dishService;

        public Dish Dish
        {
            get => _dish;
            set
            {
                _dish = value;
                OnPropertyChanged();
            }
        }

        public ICommand SaveCommand { get; }

        public EditDishViewModel(Dish dish, DishService dishService)
        {
            Dish = dish;
            _dishService = dishService;
            SaveCommand = new Command(async () =>
            {
                await _dishService.SaveEditDish(Dish);
                await Application.Current.MainPage.Navigation.PopAsync();
            });
        }
    }
}