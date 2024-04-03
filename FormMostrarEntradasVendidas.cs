using GestiónCine.Listas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace AppCine
{
    public partial class FormMostrarEntradasVendidas : Form
    {

        private List<EntradasVendidas> entradasVendidas;

        public FormMostrarEntradasVendidas()
        {
            InitializeComponent();
            this.entradasVendidas = new List<EntradasVendidas>();
            listViewEntradasVendidas.Columns.Add("Título", 120);
            listViewEntradasVendidas.Columns.Add("Precio", 100);
            listViewEntradasVendidas.Columns.Add("Cantidad", 80);
            CargarEntradasVendidasDesdeJson("entradas_vendidas.json"); // Cargar las entradas vendidas desde el archivo JSON al iniciar el formulario
            MostrarEntradasVendidasCompradas();
            CalcularBeneficiosDia();
            ActualizarTotalEntradas();
        }
        private void CargarEntradasVendidasDesdeJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                this.entradasVendidas = JsonConvert.DeserializeObject<List<EntradasVendidas>>(json);
            }
        }
        private void FormMostrarEntradasVendidas_Load(object sender, EventArgs e)
        {
            //MostrarEntradasVendidasCompradas();
            //CalcularBeneficiosDia();
        }
        //public void ActualizarEntradas(List<EntradasVendidas> nuevasEntradas)
        //{
        //    entradasVendidas.AddRange(nuevasEntradas);
        //    MostrarEntradasVendidasCompradas();
        //    CalcularBeneficiosDia();
        //}

        private void MostrarEntradasVendidasCompradas()
        {
            listViewEntradasVendidas.Items.Clear();

            foreach (EntradasVendidas entrada in entradasVendidas)
            {
                ListViewItem item = new ListViewItem(new[] { entrada.Titulo, entrada.Precio.ToString("C"), entrada.Entradas.ToString() });
                listViewEntradasVendidas.Items.Add(item);
            }
        }
        private void CalcularBeneficiosDia()
        {
            decimal totalBeneficios = 0;
            Dictionary<string, decimal> beneficiosPorPelicula = new Dictionary<string, decimal>();

            foreach (EntradasVendidas entrada in entradasVendidas)
            {
                totalBeneficios += entrada.Precio;
                if (!beneficiosPorPelicula.ContainsKey(entrada.Titulo))
                {
                    beneficiosPorPelicula.Add(entrada.Titulo, entrada.Precio);
                }
                else
                {
                    beneficiosPorPelicula[entrada.Titulo] += entrada.Precio;
                }
            }

            listBoxBeneficios.Items.Clear();

            foreach (KeyValuePair<string, decimal> kvp in beneficiosPorPelicula)
            {
                listBoxBeneficios.Items.Add($"{kvp.Key}: {kvp.Value:C}");
            }

            labelTotalBeneficios.Text = $"Total de beneficios del día: {totalBeneficios:C}";
        }
        private void ActualizarTotalEntradas()
        {
            int totalEntradas = 0;

            foreach (EntradasVendidas entrada in entradasVendidas)
            {
                totalEntradas += entrada.Entradas;
            }

            lblTotalEntradas.Text = $"Total de entradas vendidas: {totalEntradas}";
        }
        private void listViewEntradasVendidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // En el lugar donde creas la instancia del formulario FormMostrarEntradasVendidas

        }

        private void listBoxBeneficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Manejar el evento según sea necesario
        }
    }
}
