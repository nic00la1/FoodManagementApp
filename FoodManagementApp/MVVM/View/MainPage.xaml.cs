using FoodManagementApp.MVVM.ViewModel;
using Microsoft.Maui.Controls;

namespace FoodManagementApp.MVVM.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent(); 
            BindingContext = new MainPageViewModel(new Services.DishService(), Navigation);
        }
    }
}