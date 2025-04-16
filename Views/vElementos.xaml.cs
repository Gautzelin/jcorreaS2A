namespace jcorreaS2A.Views;

public partial class vElementos : ContentPage
{
	public vElementos()
	{
		InitializeComponent();
	}

    private void btnPaises_Clicked(object sender, EventArgs e)
    {
		try
		{
            if (PkPaises.SelectedIndex == -1)
            {
                DisplayAlert("Error", "el dato no existe", "Cerrar");
            } else
            {
                string pais = PkPaises.Items[PkPaises.SelectedIndex].ToString();
                DisplayAlert("Paises", "El pais seleccionado es " + pais, "Cerrar");
            }
        }
		catch (Exception ex)
		{
            DisplayAlert("Error", ex.Message, "Cerrar");
        }
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {
        string date = fecha.Date.ToString();
        DisplayAlert("Error", "la fecha es: " + date, "Cerrar");
    }
}