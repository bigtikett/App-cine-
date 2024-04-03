using GestiónCine;
using GestiónCine.Listas;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace AppCine
{
    public partial class Form1 : Form
    {
        private List<Peliculas> listaPeliculas = new List<Peliculas>();
        private List<EntradasVendidas> entradasVendidas = new List<EntradasVendidas>();
        internal Cine Cine { get; } = new Cine();
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMostrarPorGenero formMostrarPorGenero = new FormMostrarPorGenero(listaPeliculas);
            FormAgregarPelicula formAgregarPelicula = new FormAgregarPelicula(formMostrarPorGenero, listaPeliculas, formMostrarPorGenero); // Proporciona formMostrarPorGenero dos veces
            formAgregarPelicula.ShowDialog();
        }


        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormMostrarPeliculas formMostrarPeliculas = new FormMostrarPeliculas(listaPeliculas);
            formMostrarPeliculas.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormMostrarPorGenero formMostrarPorGenero = new FormMostrarPorGenero(listaPeliculas);
            formMostrarPorGenero.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormComprarEntrada formComprarEntrada = new FormComprarEntrada(listaPeliculas);
            formComprarEntrada.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormMostrarEntradasVendidas formMostrarEntradasVendidas = new FormMostrarEntradasVendidas();
            formMostrarEntradasVendidas.ShowDialog();
        }

        public void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string jsonPeliculas = JsonConvert.SerializeObject(listaPeliculas);
            string jsonEntradas = JsonConvert.SerializeObject(entradasVendidas);

            string folder = ("C:\\Users\\G4rNeTT\\source\\repos\\AppCine\\Peliculas");
            string folder2 = ("C:\\Users\\G4rNeTT\\source\\repos\\AppCine\\Entradas");

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            File.WriteAllText(folder + "\\Peliculas.json", jsonPeliculas);

            if (!Directory.Exists(folder2))
            {
                Directory.CreateDirectory(folder2);
            }
            File.WriteAllText(folder2 + "\\Vendidas.json", jsonEntradas);

            MessageBox.Show("Información guardada correctamente en archivos JSON.", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Método para guardar la lista de películas en un archivo JSON
        public static void GuardarPeliculas(List<Peliculas> peliculas, string filePath)
        {
            string json = JsonConvert.SerializeObject(peliculas);
            File.WriteAllText(filePath, json);
        }

        // Método para guardar la lista de entradas vendidas en un archivo JSON
        public static void GuardarEntradasVendidas(List<EntradasVendidas> entradasVendidas, string filePath)
        {
            string json = JsonConvert.SerializeObject(entradasVendidas);
            File.WriteAllText(filePath, json);
        }
    }
}
