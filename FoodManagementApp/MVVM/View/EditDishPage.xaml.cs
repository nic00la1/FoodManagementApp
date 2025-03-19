using FoodManagementApp.MVVM.Model;
using FoodManagementApp.MVVM.ViewModel;
using FoodManagementApp.Services;
using Microsoft.Maui.Controls;

namespace FoodManagementApp.MVVM.View
{
    public partial class EditDishPage : ContentPage
    {
        public Dish SelectedDish { get; set; }

        public EditDishPage(Dish dish)
        {
            InitializeComponent();
            BindingContext = dish;
            SelectedDish = dish;
        }

        public async void SaveEditDish(object sender, EventArgs e)
        {
            SelectedDish.SaveData(SelectedDish.Name, SelectedDish.Type, SelectedDish.Description, SelectedDish.Price, SelectedDish.Ingredients);
        }

        private void AddIngredient(object sender, EventArgs e)
        {
            SelectedDish.AddIngredients(Ing.Text);
        }
    }
}