using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace RecipeBook
{
    public partial class RecipeBookPage : ContentPage
    {
        public ObservableCollection<string> Categories { get; set; }

        public RecipeBookPage ()
        {
            InitializeComponent ();

            Categories = new ObservableCollection<string> (App.RecipesDictionary.Keys);
            CategoriesView.ItemsSource = Categories;
        }

        void Handle_Clicked (object sender, System.EventArgs e)
        {
            string categoryName = string.Format ("{0}th meal", Categories.Count + 1);
            App.RecipesDictionary [categoryName] = new List<string> ();

            Categories = new ObservableCollection<string> (App.RecipesDictionary.Keys);
            CategoriesView.ItemsSource = Categories;
        }

        async void Handle_ItemTapped (object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            await Navigation.PushAsync (new RecipesPage (e.Item.ToString ()));
        }

        void Handle_ItemSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
    }
}
