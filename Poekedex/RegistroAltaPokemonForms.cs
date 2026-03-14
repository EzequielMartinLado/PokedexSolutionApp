using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace Poekedex
{
    public partial class RegistroAltaPokemonForms : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivoImg = null;
        //private PokemonNegocio pokemonNegocio = null;
        public RegistroAltaPokemonForms()
        {
            InitializeComponent();
        }
        public RegistroAltaPokemonForms(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            //Pokemon nuevoPokemon = new Pokemon();
            PokemonNegocio pokemonNegocio = new PokemonNegocio();

            try
            {
                if(pokemon == null)
                {
                    pokemon = new Pokemon();
                }
                pokemon.Numero = int.Parse(NumeroTextBox.Text);
                pokemon.Nombre = NombreTextBox.Text;
                pokemon.Descripcion = DescripcionTextBox.Text;
                pokemon.UrlImagen = urlImagenTextBox.Text;
                pokemon.Tipo = (Elemento)TipoComboBox.SelectedItem;
                pokemon.Debilidad = (Elemento)DebilidadComboBox.SelectedItem;

                if (pokemon.Id != 0)
                { 
                    pokemonNegocio.Modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    pokemonNegocio.Agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
                }

                if (archivoImg != null && !(urlImagenTextBox.Text.ToLower().Contains("http")))
                {
                    string destino = ConfigurationManager.AppSettings["pokemon-folder"] + archivoImg.SafeFileName;
                    File.Copy(archivoImg.FileName, destino);
                    pokemon.UrlImagen = destino;
                    
                }


                Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void RegistroAltaPokemonForms_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                TipoComboBox.DataSource = elementoNegocio.Listar();
                TipoComboBox.ValueMember = "Id";
                TipoComboBox.DisplayMember = "Descripcion";
                TipoComboBox.SelectedIndex = -1;
                DebilidadComboBox.DataSource = elementoNegocio.Listar();
                DebilidadComboBox.ValueMember = "Id";
                DebilidadComboBox.DisplayMember = "Descripcion";
                DebilidadComboBox.SelectedIndex = -1;

                if(pokemon != null)
                {
                    NumeroTextBox.Text = pokemon.Numero.ToString();
                    NombreTextBox.Text = pokemon.Nombre;
                    DescripcionTextBox.Text = pokemon.Descripcion;
                    urlImagenTextBox.Text = pokemon.UrlImagen;
                    CargarImagen(pokemon.UrlImagen);
                    TipoComboBox.SelectedValue = pokemon.Tipo.Id;
                    DebilidadComboBox.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void urlImagenTextBox_Leave(object sender, EventArgs e)
        {
            CargarImagen(urlImagenTextBox.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                PokemonPictureBox.Load(imagen);

            }
            catch (Exception)
            {

                PokemonPictureBox.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQO5kCepNdhZvDKJtmPAIWnloSdTal7N1CQaA&s");
            }
        }

        private void CargarImgLocalButton_Click(object sender, EventArgs e)
        {
            archivoImg = new OpenFileDialog();
            archivoImg.Filter = "jpg|*.jpg | png|*.png";
            if (archivoImg.ShowDialog() == DialogResult.OK)
            {
                urlImagenTextBox.Text = archivoImg.FileName;
                CargarImagen(archivoImg.FileName);

                //Guardar imagen
                //File.Copy(archivoImg.FileName, ConfigurationManager.AppSettings["pokemon-folder"] + archivoImg.SafeFileName); 
            }
        }
    }
}
