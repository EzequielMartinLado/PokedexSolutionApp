using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Poekedex
{
    public partial class RegistroAltaPokemonForms : Form
    {
        private Pokemon pokemon = null;
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
            PokemonNegocio negocio = new PokemonNegocio();

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
                    negocio.Modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.Agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente");
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
                DebilidadComboBox.DataSource = elementoNegocio.Listar();
                DebilidadComboBox.ValueMember = "Id";
                DebilidadComboBox.DisplayMember = "Descripcion";

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
    }
}
