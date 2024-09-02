
using OperacionesApp.ViewModels;

namespace OperacionesApp.Views
{
    public partial class RectangleAreaView : ContentPage
    {
        public RectangleAreaView()
        {
            InitializeComponent();
            BindingContext = new RectangleAreaViewModel(); 
        }
    }
}
