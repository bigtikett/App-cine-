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
using static AppCine.FormMostrarEntradasVendidas;
using System.IO;
using Newtonsoft.Json;

namespace AppCine
{
    public partial class FormComprarEntrada : Form
    {
        private List<Peliculas> listaPeliculas;
        private List<EntradasVendidas> entradasVendidas;
        private FormMostrarEntradasVendidas formMostrarEntradasVendidas;
        public static void GuardarEntradasVendidas(List<EntradasVendidas> entradasVendidas, string filePath)
        {
            string json = JsonConvert.SerializeObject(entradasVendidas);
            File.WriteAllText(filePath, json);
        }
        public FormComprarEntrada(List<Peliculas> listaPeliculas)
        {
            InitializeComponent();
            this.listaPeliculas = listaPeliculas;
            this.entradasVendidas = new List<EntradasVendidas>();
            formMostrarEntradasVendidas = new FormMostrarEntradasVendidas();
            ////////////////////////////////////////////////////

            listViewID.View = View.Details;
            listViewID.HeaderStyle = ColumnHeaderStyle.Clickable;
            listViewID.Columns.Add("Título", 100);
            listViewID.Columns.Add("Género", 100);
            listViewID.Columns.Add("Precio (IVA incluido)", 120);
            listViewID.Columns.Add("Eliminar", 100).ImageIndex = 0;
            listViewID.SmallImageList = imageList1;
            listViewID.MouseClick += ListViewID_MouseClick;
            CargarEntradasVendidasDesdeJson("entradas_vendidas.json");
        }

        private void FormComprarEntrada_Load(object sender, EventArgs e)
        {

        }
        private void CargarEntradasVendidasDesdeJson(string filePath)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                this.entradasVendidas = JsonConvert.DeserializeObject<List<EntradasVendidas>>(json);
            }
        }
        private void btnComprobarID_Click(object sender, EventArgs e)
        {
            int idIngresada;
            if (!int.TryParse(txtIDPelicula.Text, out idIngresada))
            {
                MessageBox.Show("Por favor, ingrese un número correcto para la ID de la Película.");
                return;
            }

            bool peliculaEncontrada = false;
            foreach (Peliculas pelicula in listaPeliculas)
            {
                if (pelicula.ID == idIngresada)
                {
                    MessageBox.Show($"La película '{pelicula.Titulo}' fue encontrada!");

                    // Crear una nueva instancia de EntradasVendidas con el título y el precio de la película
                    EntradasVendidas nuevaEntrada = new EntradasVendidas
                    {
                        Titulo = pelicula.Titulo,
                        Precio = pelicula.Precio * 1.21m // Calcular el precio total con IVA
                    };

                    // Agregar la nueva entrada a la lista de entradas vendidas

                    // Agregar la película al ListView
                    ListViewItem item = new ListViewItem(new[] { pelicula.Titulo, pelicula.Genero.ToString(), nuevaEntrada.Precio.ToString("C") });
                    item.Tag = listViewID.Items.Count - 1; // Almacena el índice del ítem en el Tag para su identificación
                    item.ImageIndex = 0;
                    listViewID.Items.Add(item);
                    peliculaEncontrada = true;
                    break;
                }

            }

            if (!peliculaEncontrada)
            {
                MessageBox.Show("No se encontró ninguna película con la ID ingresada.");
            }
        }
        private void ListViewID_MouseClick(object sender, MouseEventArgs e)
        {
            ListView listView = sender as ListView;
            ListViewHitTestInfo hit = listView.HitTest(e.Location);

            if (hit.Item != null)
            {
                // Verifica si se hizo clic en la primera subítema correspondiente al ícono de la papelera
                if (hit.SubItem == hit.Item.SubItems[0])
                {
                    // Obtiene el índice del ítem
                    int indice = hit.Item.Index;

                    // Elimina la película del ListView y de la lista de entradas vendidas
                    listViewID.Items.RemoveAt(indice);
                    entradasVendidas.RemoveAt(indice);
                }
            }
        }

        private void btnNEntradas_Click(object sender, EventArgs e)
        {
            // Verificar si hay al menos una película en listViewID
            if (listViewID.Items.Count > 0)
            {
                // Obtener la información de la primera película en listViewID
                string titulo = listViewID.Items[0].SubItems[0].Text;
                string genero = listViewID.Items[0].SubItems[1].Text;
                decimal precio = decimal.Parse(listViewID.Items[0].SubItems[2].Text, System.Globalization.NumberStyles.Currency);

                // Obtener el número de entradas ingresado por el usuario
                int numEntradas = int.Parse(txtNEntradas.Text);

                // Asignar asientos y obtener la cadena de números de asientos asignados
                string numerosAsientos = AsignarAsientos(numEntradas);

                // Calcular el precio total
                decimal precioTotal = precio * numEntradas * 1.21m; // Se multiplica por 1.21 para agregar el IVA

                // Mostrar el mensaje con la información de la compra, incluyendo los números de asientos asignados
                string mensaje = $"Has comprado {numEntradas} entradas para la película '{titulo}' ({genero}).\n";
                mensaje += $"Precio total: {precioTotal:C}\n";
                mensaje += $"Fecha de hoy: {DateTime.Now.ToString("dd/MM/yyyy")}\n";
                mensaje += "Asientos asignados:\n";
                mensaje += numerosAsientos;

                MessageBox.Show(mensaje, "Compra realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Crear una nueva entrada
                EntradasVendidas nuevaEntrada = new EntradasVendidas
                {
                    Titulo = titulo,
                    Precio = precioTotal, // Aquí debes usar el precio total calculado
                    Entradas = numEntradas
                };

                // Agregar la nueva entrada a la lista de entradas vendidas
                entradasVendidas.Add(nuevaEntrada);
                GuardarEntradasVendidas(entradasVendidas, "entradas_vendidas.json");

                // Mostrar el formulario para mostrar las entradas vendidas
            }

            else
            {
                MessageBox.Show("No hay ninguna película en la lista para comprar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //private void MostrarEntradasVendidas()
        //{
        //    // Crear o actualizar el formulario para mostrar las entradas vendidas
        //    if (formMostrarEntradasVendidas == null || formMostrarEntradasVendidas.IsDisposed)
        //    {
        //        formMostrarEntradasVendidas = new FormMostrarEntradasVendidas();
        //    }
        //    else
        //    {
        //        formMostrarEntradasVendidas.ActualizarEntradas();
        //    }

        //    // Mostrar el formulario
        //    formMostrarEntradasVendidas.Show();
        //}
        private string AsignarAsientos(int numEntradas)
        {
            StringBuilder sb = new StringBuilder();
            if (numEntradas > 0)
            {
                Random rnd = new Random();
                for(int i = 0; i < numEntradas; i++)
                {
                    int numeroAsiento = rnd.Next(0, 100);
                    sb.Append($"Asiento asignado: {numeroAsiento:D2}\n");
                }
            }
            return sb.ToString();
        }
    }
}