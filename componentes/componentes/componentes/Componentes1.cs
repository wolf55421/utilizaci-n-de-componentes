using System;
using System.Windows.Forms;

namespace componentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Método para abrir un archivo PDF (Botón 1)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos PDF|*.pdf"; // Para filtrar solo archivos PDF

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    axAcroPDF1.LoadFile(openFileDialog.FileName); // Cargar el archivo PDF
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo PDF: " + ex.Message);
            }
        }

        // Método para abrir un archivo multimedia (Botón 2)
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos multimedia|*.mp3;*.mp4;*.wav;*.wmv"; // Para filtrar archivos multimedia

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    
                    axWindowsMediaPlayer1.URL = openFileDialog.FileName; // Cargar el archivo multimedia
                    axWindowsMediaPlayer1.Ctlcontrols.play(); // Reproducir el archivo multimedia
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el archivo multimedia: " + ex.Message);
            }
        }

        // Método para abrir una página web (Botón 3)
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string url = "https://www.google.com"; // La URL predeterminada

                
                // url = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la URL", "Navegador Web", "https://www.google.com");

                if (!string.IsNullOrEmpty(url))
                {
                    webBrowser1.Navigate(url); // Navegar a la URL especificada
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la página web: " + ex.Message);
            }
        }

        
        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

