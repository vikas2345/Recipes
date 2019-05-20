using Recipes.Model;
using Recipes.ViewCells;
using Xamarin.Forms;

namespace Recipes.DataTemplateSelectors
{
    public class RecipeDataTemplateSelector : DataTemplateSelector
    {
        readonly DataTemplate recipeTemplate;
        readonly DataTemplate recommendedTemplate;

        public RecipeDataTemplateSelector()
        {
            recipeTemplate = new DataTemplate(typeof(RecipeCell));
            recommendedTemplate = new DataTemplate(typeof(RecommendedRecipeCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var recipe = item as Recipe;
            if (recipe == null)
                return null;

            return recipe.IsRecommended ? recommendedTemplate : recipeTemplate;

        }
    }
}
