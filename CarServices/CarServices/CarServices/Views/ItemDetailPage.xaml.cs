using CarServices.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CarServices.Views
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