namespace jcorreaS2A.Views;

public partial class vLogin : ContentPage
{
    string[] users = { "Carlos", "Ana", "Jose" };
    string[] passwords = { "carlos123", "ana123", "jose123" };
    public vLogin()
	{
		InitializeComponent();
	}

    private void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {
        string userInput = txtUsuario.Text?.Trim();
        string passInput = txtContrasena.Text?.Trim();

        for (int i = 0; i < users.Length; i++)
        {
            if (users[i].Equals(userInput, StringComparison.OrdinalIgnoreCase) &&
                passwords[i] == passInput)
            {
                // Navegar a la nueva página y pasar el nombre del usuario
                Navigation.PushAsync(new vElementos(users[i]));
                return;
            }
        }

        lblMensaje.Text = "Usuario o contraseña incorrectos.";
        lblMensaje.TextColor = Colors.Red;

    }
}