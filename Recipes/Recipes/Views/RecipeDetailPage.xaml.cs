﻿using System;
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
	public partial class RecipeDetailPage : ContentPage
	{
		public RecipeDetailPage ()
		{
			InitializeComponent ();
		}

        public RecipeDetailPage(Recipe recipe)
        {
            InitializeComponent();
        }
	}
}