using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OperacionesApp.ViewModels
{
    public partial class RectangleAreaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double largo;

        [ObservableProperty]
        private double ancho;

        [ObservableProperty]
        private double resultado;

        [RelayCommand]
        private void Calcular()
        {
            if (Largo > 0 && Ancho > 0)
            {
                Resultado = Largo * Ancho;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Por favor, ingrese valores válidos para largo y ancho.", "Aceptar");
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Largo = 0;
            Ancho = 0;
            Resultado = 0;
        }
    }
}