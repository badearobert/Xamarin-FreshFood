﻿using FreshFood.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FreshFood.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Content_RecipesView : ContentView
    {
        public Content_RecipesView()
        {
            InitializeComponent();
            BindingContext = new Content_RecipesViewModel();
        }
    }
}