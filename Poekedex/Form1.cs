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
            CampoComboBox.Items.Add("Número");
            CampoComboBox.Items.Add("Nombre");
            CampoComboBox.Items.Add("Tipo");
        }
        private void ActualizarCargaDGV()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listaPokemon = negocio.ListarPokemon();
                PokemonDataGridView.DataSource = listaPokemon;
                OcultarColumnas();
                CargarImagen(listaPokemon[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void OcultarColumnas()
        {
            PokemonDataGridView.Columns["UrlImagen"].Visible = false;
            PokemonDataGridView.Columns["Id"].Visible = false;

        }
        private void PokemonDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(PokemonDataGridView.CurrentRow != null)
            {
                Pokemon pokemonSeleccionado = (Pokemon)PokemonDataGridView.CurrentRow.DataBoundItem;
                CargarImagen(pokemonSeleccionado.UrlImagen);
            }
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

        private bool ValidarFiltro()
        {
            string validacion;
            if (CampoComboBox.SelectedIndex < 0)
            {
                validacion = "Por favor seleccionar un campo";
                ValidarLabel.Text = validacion;
                ValidarLabel.ForeColor = Color.Red;
                
                return true;
                
            }

            if(CriterioComboBox.SelectedIndex < 0)
            {
                validacion = "Por favor seleccionar un criterio";
                ValidarLabel.Text = validacion;
                ValidarLabel.ForeColor = Color.Red;

                return true;
            }

            if (CampoComboBox.SelectedItem.ToString() == "Número")
            {
                if (string.IsNullOrEmpty(FiltroBDTextBox.Text)) 
                { 
                    validacion = "Por favor, ingresar un número";
                    ValidarLabel.Text = validacion;
                    ValidarLabel.ForeColor = Color.Red;
                    return true;
                    
                }
                if (!(soloNumero(FiltroBDTextBox.Text)))
                {
                    validacion = "Por favor, ingresar solo número";
                    ValidarLabel.Text = validacion;
                    ValidarLabel.ForeColor = Color.Red;
                    return true;

                }
            }
            ValidarLabel.Hide();
            return false;
        }

        private bool soloNumero (string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }
            return true;
        }
        private void FiltroButton_Click(object sender, EventArgs e)
        {
            
            PokemonNegocio pokemonNegocio = new PokemonNegocio();
            /*try
            {
                if (ValidarFiltro())
                    return;
                string campo = CampoComboBox.SelectedItem.ToString();
                string criterio = CriterioComboBox.SelectedItem.ToString();
                string filtro = FiltroBDTextBox.Text;
                PokemonDataGridView.DataSource = pokemonNegocio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }*/
            while (!(ValidarFiltro()))
            {
                string campo = CampoComboBox.SelectedItem.ToString();
                string criterio = CriterioComboBox.SelectedItem.ToString();
                string filtro = FiltroBDTextBox.Text;
                PokemonDataGridView.DataSource = pokemonNegocio.Filtrar(campo, criterio, filtro);
                return;
            }
        }

        private void FiltroTextBox_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = FiltroTextBox.Text;

            if (filtro.Length >= 2)
            {
                listaFiltrada = listaPokemon.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaPokemon;
            }

            PokemonDataGridView.DataSource = null;
            PokemonDataGridView.DataSource = listaFiltrada;
            OcultarColumnas();
        }
       
        private void CampoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = CampoComboBox.SelectedItem.ToString();
            if (opcion == "Número")
            {
                CriterioComboBox.Items.Clear();
                CriterioComboBox.Items.Add("Mayor a");
                CriterioComboBox.Items.Add("Menor a");
                CriterioComboBox.Items.Add("Igual a");
            }
            else
            {
                CriterioComboBox.Items.Clear();
                CriterioComboBox.Items.Add("Empiezan con");
                CriterioComboBox.Items.Add("Termina con");
                CriterioComboBox.Items.Add("Contiene");
            }
        }

       
    }
}
