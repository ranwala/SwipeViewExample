using System.Collections.ObjectModel;
using System.Windows.Input;
using SwipeButton.Models;
using Xamarin.Forms;

namespace SwipeButton.ViewModels
{
    public class FruitPageViewModel
    {
        public ICommand DeleteCommand { get; set; }
        public ICommand AddFavoriteCommand { get; set; }

        public FruitPageViewModel()
        {
            DeleteCommand = new Command<Fruit>(DeleteItem);
            AddFavoriteCommand = new Command<Fruit>(AddFavorite);
        }

        private async void AddFavorite(Fruit obj)
        {
            await Application.Current.MainPage.DisplayAlert("Mark Favorite", "Add this fruit as favorite", "Ok");
        }


        private async void DeleteItem(Fruit obj)
        {
            await Application.Current.MainPage.DisplayAlert("Delete Item", "Are you sure, you want to delete this item!", "Delete");
        }

        public ObservableCollection<Fruit> FruitCollection { get; } = new ObservableCollection<Fruit>
        {
            new Fruit
            {
                Name = "Apple",
                Price = "500"
            },
            new Fruit
            {
                Name = "Mango",
                Price = "300"
            },
            new Fruit
            {
                Name = "Papaya",
                Price = "60"
            },
            new Fruit
            {
                Name = "Pineapple",
                Price = "600"
            },
            new Fruit
            {
                Name = "Wood Apple",
                Price = "500"
            },
            new Fruit
            {
                Name = "Guava",
                Price = "45"
            },
            new Fruit
            {
                Name = "WaterMelon",
                Price = "50"
            },
            new Fruit
            {
                Name = "Banana",
                Price = "100"
            }
        };
    }
}