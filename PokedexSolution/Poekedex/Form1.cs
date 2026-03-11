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
using Poekedex;

namespace Pokedex
{
    public partial class PokedexForm : Form
    {
        private List<Pokemon> listaPokemon;
        public PokedexForm()
        {
            InitializeComponent();
        }

        private void frmPokedex_Load(object sender, EventArgs e)
        {
            ActualizarCargaDGV();
        }
        private void ActualizarCargaDGV()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.ListarPokemon();
                PokemonDataGridView.DataSource = listaPokemon;
                PokemonDataGridView.Columns["UrlImagen"].Visible = false;
                PokemonDataGridView.Columns["Id"].Visible = false;
                CargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PokemonDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon pokemonSeleccionado = (Pokemon)PokemonDataGridView.CurrentRow.DataBoundItem;
            CargarImagen(pokemonSeleccionado.UrlImagen);
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

        private void AgregarButton_Click(object sender, EventArgs e)
        {
            RegistroAltaPokemonForms registro = new RegistroAltaPokemonForms();
            registro.ShowDialog();
            ActualizarCargaDGV();
        }

        private void ModificarButton_Click(object sender, EventArgs e)
        {
            Pokemon pokemonSeleccionado;
            pokemonSeleccionado = (Pokemon)PokemonDataGridView.CurrentRow.DataBoundItem;

            RegistroAltaPokemonForms modificar = new RegistroAltaPokemonForms(pokemonSeleccionado);
            modificar.ShowDialog();
            ActualizarCargaDGV();
            
        }

        private void EliminarFisicoButton_Click(object sender, EventArgs e)
        {
            Eliminar();
        }


        private void Eliminar(bool logico = false)
        {
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            Pokemon pokemonSeleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Está a punto de eliminar un registro, ¿Está seguro?", "Eliminar Pokemon", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    pokemonSeleccionado = (Pokemon)PokemonDataGridView.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        pokemonNegocio.EliminarLogico(pokemonSeleccionado.Id);
                    }
                    else
                    {
                        pokemonNegocio.EliminarFisico(pokemonSeleccionado.Id);
                    }

                    ActualizarCargaDGV();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void EliminarLogicoButton_Click(object sender, EventArgs e)
        {
            Eliminar(true);
        }
    }
}
