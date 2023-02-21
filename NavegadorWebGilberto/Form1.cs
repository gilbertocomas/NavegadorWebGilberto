using System;
using System.Windows.Forms;

namespace NavegadorWebGilberto
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await webView21.EnsureCoreWebView2Async();
        }
        
        private void btnIr_Click(object sender, EventArgs e)
        {
            //Boton para navegar a la URL indicada en el TextBox
            String direccion = txtURL.Text;
            if (!direccion.Contains("https://"))
            {
                direccion = "https://" + direccion;
            }
            webView21.CoreWebView2.Navigate(direccion);
               
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoBack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.GoForward();
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Reload();
        }

        private void btnAlto_Click(object sender, EventArgs e)
        {
            webView21.CoreWebView2.Stop();
        }

        private void btnHome_Click_1(object sender, EventArgs e)
        {
            // Reemplaza la URL de ejemplo con la página de inicio que deseas cargar
            String direccion = "https://www.google.com";
            txtURL.Text = direccion;
            webView21.CoreWebView2.Navigate(txtURL.Text);
        }
    }
}
