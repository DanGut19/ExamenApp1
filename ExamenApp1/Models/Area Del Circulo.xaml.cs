namespace ExamenApp1.Models;

public partial class Area_Del_Circulo : ContentPage
{

	public double Radio { get; set; }

	public double CalcularArea() 
	{
		return Math.PI * Math.Pow(Radio, 2);
	}

	public Area_Del_Circulo()
	{
		InitializeComponent();
	}
}