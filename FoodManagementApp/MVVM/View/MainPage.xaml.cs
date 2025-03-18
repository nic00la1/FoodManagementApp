using FoodManagementApp.MVVM.ViewModel;
using Microsoft.Maui.Controls;

namespace FoodManagementApp.MVVM.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }

        private void OnDishTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item != null)
            {
                ((MainPageViewModel)BindingContext).DishTappedCommand.Execute(e.Item);
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}