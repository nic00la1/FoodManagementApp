using FoodManagementApp.MVVM.ViewModel;

namespace FoodManagementApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
    }

}
