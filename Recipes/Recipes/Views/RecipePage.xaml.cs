using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private async void Recipe_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var recipeSelected = e.SelectedItem as Recipe;

            if (recipeSelected == null)
                return;

            await Navigation.PushAsync(new RecipeDetailPage(recipeSelected));
        }
    }
}