using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscosApp
{
    public partial class frmAgregar : Form
    {
        OpenFileDialog archivo = null;
        private Disco Disco = null;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Disco disco)
        {
            InitializeComponent();
            this.Disco = disco;
            Text = "Editar";
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            TipoEdicionNegocio formatoNegocio = new TipoEdicionNegocio();
            EstiloNegocio estiloNegocio = new EstiloNegocio();

            try
            {
                cmbEstilo.DataSource = estiloNegocio.listaEstilo();
                cmbEstilo.ValueMember = "Id";
                cmbEstilo.DisplayMember = "Descripcion";

                cmbTipoEdicion.DataSource = formatoNegocio.listaTipoEdicion();
                cmbTipoEdicion.ValueMember = "Id";
                cmbTipoEdicion.DisplayMember = "Descripcion";

                if(Disco != null)
                {
                    txtIDAgr.Text = Disco.Id.ToString();
                    txtTituloAgr.Text = Disco.Titulo.ToString();
                    txtFechaLanzamientoAgr.Text = Disco.FechaLanzamiento.ToString();
                    txtCantidadCancionesAgr.Text = Disco.CantidadCanciones.ToString();
                    txtURLAgr.Text = Disco.UrlImagenTapa.ToString();
                    CargarImagen(Disco.UrlImagenTapa);
                    cmbEstilo.SelectedValue = Disco.Estilo.Id;
                    cmbTipoEdicion.SelectedValue = Disco.TipoEdicion.Id;
                    txtActivoAgr.Text = Disco.Activo.ToString();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void CargarImagen(string UrlImagenTapa)
        {

            try
            {
                picBxDiscoAgr.Load(UrlImagenTapa);
            }
            catch (Exception)
            {
                picBxDiscoAgr.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtURLAgr_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtURLAgr.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                if (Disco == null)
                    Disco = new Disco();

                Disco.Titulo = txtTituloAgr.Text;
                Disco.CantidadCanciones = int.Parse(txtCantidadCancionesAgr.Text);
                Disco.FechaLanzamiento = DateTime.Parse(txtFechaLanzamientoAgr.Text);
                Disco.UrlImagenTapa = txtURLAgr.Text;
                Disco.Activo = bool.Parse(txtIDAgr.Text);

                Disco.Estilo = new Estilo();
                Disco.Estilo = (Estilo)cmbEstilo.SelectedItem;

                Disco.TipoEdicion = new TipoEdicion();
                Disco.TipoEdicion = (TipoEdicion)cmbTipoEdicion.SelectedItem;

                if (Disco.Id != 0)
                {
                    if (string.IsNullOrEmpty(txtTituloAgr.Text))
                    {
                        MessageBox.Show("El Titulo es obligatorio");
                    } else if (!(soloNumeros(txtCantidadCancionesAgr.Text)) || txtCantidadCancionesAgr.Text == "")
                    {
                        MessageBox.Show("La cantidad de canciones es un numero obligatorio");
                    }
                    else
                    {
                        negocio.Modificar(Disco);
                        MessageBox.Show("Disco Modificado");
                        Close();
                    }
                }
                else
                {
                    negocio.Agregar(Disco);
                    MessageBox.Show("Disco Agregado");
                    Close();
                }

                if (archivo != null && (txtURLAgr.Text.ToLower().Contains("http")))
                    File.Copy(txtURLAgr.Text, ConfigurationManager.AppSettings["img-Local"] + archivo.SafeFileName);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnURLImagenAgr_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Multiselect = false;
            archivo.Filter = "jpg|*.jpg; |png|*.png";

            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtURLAgr.Text = archivo.FileName;
                CargarImagen(txtURLAgr.Text);
            }
        }

        private bool soloNumeros(string texto)
        {
            foreach (char caracter in texto)
            {
                if(!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
    }
}
