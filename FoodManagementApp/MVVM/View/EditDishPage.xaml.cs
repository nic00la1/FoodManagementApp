using FoodManagementApp.MVVM.Model;
using FoodManagementApp.MVVM.ViewModel;
using FoodManagementApp.Services;
using Microsoft.Maui.Controls;

namespace FoodManagementApp.MVVM.View
{
    public partial class EditDishPage : ContentPage
    {
        public EditDishPage(Dish dish, DishService dishService)
        {
            InitializeComponent();
            BindingContext = new EditDishViewModel(dish, dishService);
        }
    }
}