namespace ExamenApp1.Models;

public partial class Area_Del_Rectangulo : ContentPage
{

    public double Base { get; set; }

    public double Altura { get; set; }

    public double Calcular()
    {
        return Base * Altura;
    }

    public Area_Del_Rectangulo()
    {
        InitializeComponent();
    }
}
