using GestiónCine;
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
using static GestiónCine.Listas.Peliculas;

namespace AppCine
{

    public partial class FormMostrarPorGenero : Form
    {
        private Dictionary<TipoGenero, List<string>> peliculasPorGenero = new Dictionary<TipoGenero, List<string>>();

        public FormMostrarPorGenero(List<Peliculas> listaPeliculas)
        {
            InitializeComponent();
            listView1.Columns.Add("", 0);

            // Crear manualmente las columnas del ListView según los géneros
            foreach (TipoGenero genero in Enum.GetValues(typeof(TipoGenero)))
            {
                peliculasPorGenero.Add(genero, new List<string>());
                listView1.Columns.Add(genero.ToString(), 70); // Agregar columna con el nombre del género
            }

            // Agregar las películas al ListView
            foreach (Peliculas pelicula in listaPeliculas)
            {
                AgregarPelicula(pelicula);
            }

            // Agregar el evento SelectedIndexChanged al ListView
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        }

        public void AgregarPelicula(Peliculas pelicula)
        {
            // Agregar el título de la película a la lista correspondiente al género
            peliculasPorGenero[pelicula.Genero].Add(pelicula.Titulo);

            // Actualizar el ListView con las películas por género
            ActualizarListView();
        }
        private void ActualizarListView()
        {
            // Limpiar el ListView
            listView1.Items.Clear();

            // Obtener el número máximo de películas por género
            int maxCount = peliculasPorGenero.Max(x => x.Value.Count);

            // Agregar las películas al ListView por género
            for (int i = 0; i < maxCount; i++)
            {
                ListViewItem item = new ListViewItem();

                foreach (KeyValuePair<TipoGenero, List<string>> kvp in peliculasPorGenero)
                {
                    TipoGenero genero = kvp.Key;
                    List<string> peliculas = kvp.Value;

                    // Obtener el índice de la columna correspondiente al género
                    int columnIndex = listView1.Columns.IndexOfKey(genero.ToString());

                    // Agregar la película en la posición i de la lista del género
                    if (i < peliculas.Count)
                    {
                        item.SubItems.Add(peliculas[i]);
                    }
                    else
                    {
                        item.SubItems.Add("");
                    }
                }

                // Agregar el item al ListView
                listView1.Items.Add(item);
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí puedes colocar el código para manejar el evento
        }
    }
}
