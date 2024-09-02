using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;


namespace OperacionesApp.ViewModels
{
    public partial class SquareAreaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double lado;

        [ObservableProperty]
        private double resultado;

        [RelayCommand]
        private void Calcular()
        {
            if (Lado > 0)
            {
                Resultado = Lado * Lado;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Por favor, ingrese un valor válido para el lado.", "Aceptar");
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Lado = 0;
            Resultado = 0;
        }
    }
}
