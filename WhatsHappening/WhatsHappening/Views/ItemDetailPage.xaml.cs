using System.ComponentModel;
using WhatsHappening.ViewModels;
using Xamarin.Forms;

namespace WhatsHappening.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}