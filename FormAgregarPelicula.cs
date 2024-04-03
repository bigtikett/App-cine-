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
using GestiónCine;
using Newtonsoft.Json;

namespace AppCine
{
    public partial class FormAgregarPelicula : Form
    {
        private List<Peliculas> listaPeliculas;
        private FormMostrarPorGenero formMostrarPorGenero;
        private FormMostrarPorGenero formMostrarPorGeneroRef;

        public FormAgregarPelicula(FormMostrarPorGenero formMostrarPorGenero, List<Peliculas> listaPeliculas, FormMostrarPorGenero formMostrarPorGeneroRef)
        {
            InitializeComponent();
            this.formMostrarPorGenero = formMostrarPorGenero;
            this.listaPeliculas = listaPeliculas;
            this.formMostrarPorGeneroRef = formMostrarPorGeneroRef; // Referencia al formulario FormMostrarPorGenero
        }

        private void GuardarPeliculasEnJson()
        {
            string json = JsonConvert.SerializeObject(listaPeliculas);
            string filePath = "Peliculas.json"; // Ruta del archivo JSON
            File.WriteAllText(filePath, json);
        }
        private void btnAgregarPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                Peliculas peliculas = new Peliculas();
                peliculas.Titulo = txtTitulo.Text;
                peliculas.Genero = (TipoGenero)Enum.Parse(typeof(TipoGenero), cmbGenero.SelectedItem.ToString());
                peliculas.Precio = decimal.Parse(txtPrecio.Text);

                // Verificar si la película ya existe en la lista
                if (!listaPeliculas.Any(p => p.Titulo == peliculas.Titulo))
                {
                    peliculas.ID = listaPeliculas.Count + 1;
                    listaPeliculas.Add(peliculas);
                    MessageBox.Show("Película agregada con éxito!");
                    GuardarPeliculasEnJson();
                    // Agregar la película al formulario FormMostrarPorGenero
                    formMostrarPorGeneroRef.AgregarPelicula(peliculas);
                }
                else
                {
                    MessageBox.Show("La película ya está en la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar película: {ex.Message}");
            }
        }
    }
}
