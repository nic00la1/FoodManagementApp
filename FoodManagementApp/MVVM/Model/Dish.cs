using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FoodManagementApp.MVVM.Model
{
    public class Dish
    {
        private string _name;
        private string _type;
        private string _description;
        private double _price;
        private ObservableCollection<string> _ingredients;
        public int Id { get; set; }
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Type
        {
            get => _type;
            set
            {
                _type = value;
                OnPropertyChanged(nameof(Type));
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                _price = value;
                OnPropertyChanged(nameof(Price));
            }
        }
        public string ImageUrl { get; set; }
        public ObservableCollection<string> Ingredients
        {
            get => _ingredients;
            set
            {
                _ingredients = value;
                OnPropertyChanged(nameof(Ingredients));
            }
        }
        public void AddIngredients(string ingredient)
        {
            Ingredients.Add(ingredient);

            OnPropertyChanged(nameof(Ingredients));
        }

        public void SaveData(string name, string type, string description, double price, ObservableCollection<string> ingredients)
        {
            Name = name;
            Description = description;
            Type = type;
            Price = price;
            Ingredients = ingredients;
        }
        public event PropertyChangedEventHandler? PropertyChanged;




        // Metoda dzięki której powiadamiamy o zmianie w naszym obiekcie
        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}