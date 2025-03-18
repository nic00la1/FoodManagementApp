using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodManagementApp.MVVM.Model
{
    public class Dish
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public ObservableCollection<string> Ingredients { get; set; }
        public string ImageUrl { get; set; }
    }
}
