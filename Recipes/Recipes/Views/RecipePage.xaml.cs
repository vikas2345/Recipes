using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipes.DependencyService;
using Recipes.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Recipes.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RecipePage : ContentPage
	{
		public RecipePage ()
		{
			InitializeComponent ();
		}

        private void Recipe_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var recipeSelected = e.SelectedItem as Recipe;

            if (recipeSelected == null)
                return;

            Navigation.PushAsync(new RecipeDetailPage(recipeSelected));

        }
    }
}