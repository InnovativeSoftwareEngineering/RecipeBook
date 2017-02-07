using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace RecipeBook
{
    public partial class App : Application
    {
        public static IDictionary<string, IList<string>> RecipesDictionary { get; set; }

        public App ()
        {
            initializeDictionary ();
            InitializeComponent ();

            MainPage = new NavigationPage(new RecipeBookPage ());

        }

        private void initializeDictionary ()
        {
            RecipesDictionary = new Dictionary<string, IList<string>> ();
            RecipesDictionary["Breakfast"] = new List<string> {
                "Cereal", "Eggs", "Bacon", "Pancakes", "Cold Pizza"
            };
            RecipesDictionary ["Lunch"] = new List<string> {
                "Cereal", "Salad", "Soup", "Sandwich", "Pizza"
            };
            RecipesDictionary ["Dinner"] = new List<string> {
                "Cereal", "Sushi", "Steak", "Tacos", "Pizza"
            };
        }

        protected override void OnStart ()
        {
            // Handle when your app starts
        }

        protected override void OnSleep ()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume ()
        {
            // Handle when your app resumes
        }
    }
}
