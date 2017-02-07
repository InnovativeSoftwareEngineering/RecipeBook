using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace RecipeBook
{
    public partial class RecipesPage : ContentPage
    {
        public ObservableCollection<string> Recipes { get; set; }

        public RecipesPage (string category)
        {
            InitializeComponent ();
            Recipes = new ObservableCollection<string> (App.RecipesDictionary [category]);
            this.Title = category;
            RecipesView.ItemsSource = Recipes;
        }

        void Handle_Clicked (object sender, System.EventArgs e)
        {
            App.RecipesDictionary [Title].Add (RecipeName.Text);

            Recipes = new ObservableCollection<string> (App.RecipesDictionary[Title]);
            RecipesView.ItemsSource = Recipes;

            RecipeName.Text = "";
        }

        async void Handle_ItemTapped (object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            // TODO: View/edit recipe details
        }
    }
}
