using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ExamenApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApp1.ViewModels
{
    internal partial class MainPageViewModels : ObservableObject
    {
        [ObservableProperty]
        private double _base;

        [ObservableProperty]
        private double _altura;

        [ObservableProperty]
        private double _resultado;

        [ObservableProperty]
        private double _radio;

        [RelayCommand]

        private void CalcularArea() 
        {
            try 
            {
                Area_Del_Circulo r = new Area_Del_Circulo();
                r.Radio = Radio;

                _resultado = r.CalcularArea();
            } 
            catch (Exception ex) 
            {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }

        [RelayCommand]
        private void Calcular() 
        {
            try
            {
                Area_Del_Rectangulo r = new Area_Del_Rectangulo();
                r.Base = Base;
                r.Altura = Altura;

                Resultado = r.Calcular();
            }
            catch (Exception ex)
            {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Base = 0;
            Altura = 0;
            Radio = 0;
            Resultado = 0;
        }
    }
}
