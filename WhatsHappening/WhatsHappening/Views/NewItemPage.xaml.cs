using System;
using System.Collections.Generic;
using System.ComponentModel;
using WhatsHappening.Models;
using WhatsHappening.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WhatsHappening.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}