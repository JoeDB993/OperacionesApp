using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OperacionesApp.ViewModels
{
    public partial class CircleAreaViewModel : ObservableObject
    {
        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double resultado;

        [RelayCommand]
        private void Calcular()
        {
            if (Radio > 0)
            {
                Resultado = Math.PI * Radio * Radio;
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Por favor, ingrese un valor válido para el radio.", "Aceptar");
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Radio = 0;
            Resultado = 0;
        }
    }
}