
using Microsoft.Maui.Controls;
using OperacionesApp.ViewModels;

namespace OperacionesApp.Views
{
    public partial class SquareAreaView : ContentPage
    {
        public SquareAreaView()
        {
            InitializeComponent();
            BindingContext = new SquareAreaViewModel(); 
        }
    }
}