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
using GestiónCine;

namespace AppCine
{
    public partial class FormMostrarPeliculas : Form
    {
        private List<Peliculas> listaPeliculas;
        public FormMostrarPeliculas(List<Peliculas> listaPeliculas)
        {
            InitializeComponent();
            this.listaPeliculas = listaPeliculas;
            MostrarPeliculas();
        }
        public void MostrarPeliculas()
        {
            foreach (Peliculas pelicula in listaPeliculas)
            {
                ListViewItem item = new ListViewItem(pelicula.ID.ToString());
                item.SubItems.Add(pelicula.Titulo);
                item.SubItems.Add(pelicula.Genero.ToString());
                item.SubItems.Add(pelicula.Precio.ToString("C"));
                
                listViewPeliculas.Items.Add(item);
            }
        }

        private void FormMostrarPeliculas_Load(object sender, EventArgs e)
        {
            
            
        }
        private void listViewPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
