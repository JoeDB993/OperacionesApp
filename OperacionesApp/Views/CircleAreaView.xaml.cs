using OperacionesApp.ViewModels;

namespace OperacionesApp.Views
{
    public partial class CircleAreaView : ContentPage
    {
        public CircleAreaView()
        {
            InitializeComponent();
            BindingContext = new CircleAreaViewModel(); 
        }
    }
}
