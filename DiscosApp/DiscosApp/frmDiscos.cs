using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace DiscosApp
{
    public partial class frmDiscos : Form
    {
        private List<Disco> listaDiscos;
        public frmDiscos()
        {
            InitializeComponent();
        }

        private void frmCatalogoDiscos_Load(object sender, EventArgs e)
        {
            Cargar();
            cmbCampo.Items.Add("Titulo");
            cmbCampo.SelectedIndex = 0;
            cmbCampo.Items.Add("Año");
            cmbCampo.Items.Add("Estilo");
            cmbCampo.Items.Add("Formato");
        }


        private void Cargar()
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                listaDiscos = negocio.listar();
                dgvDiscos.DataSource = listaDiscos;
                ocultarColumnas();
                picBxDisco.Load(listaDiscos[0].UrlImagenTapa);
            }
            catch (Exception ex)
            {

                CargarImagen("UrlImagenTapa");
            }
        }

        private void ocultarColumnas()
        {
            dgvDiscos.Columns["Id"].Visible = false;
            dgvDiscos.Columns["FechaLanzamiento"].Visible = false;
            dgvDiscos.Columns["CantidadCanciones"].Visible = false;
            dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
            dgvDiscos.Columns["TipoEdicion"].Visible = false;
            dgvDiscos.Columns["Activo"].Visible = false;
        }

        private void CargarImagen(string UrlImagenTapa)
        {

            try
            {
                picBxDisco.Load(UrlImagenTapa);
            }
            catch (Exception)
            {
                picBxDisco.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                CargarImagen(seleccionado.UrlImagenTapa);

                txtIDDet.Text = seleccionado.Id.ToString();
                txtTituloDet.Text = seleccionado.Titulo.ToString();
                txtCantidadCancionesDet.Text = seleccionado.CantidadCanciones.ToString();
                txtIFechaLanzamientoDet.Text = seleccionado.FechaLanzamiento.ToString();
                txtURLDet.Text = seleccionado.UrlImagenTapa.ToString();
                txtEstiloDet.Text = seleccionado.Estilo.Descripcion.ToString();
                txtTipoEdicionDet.Text = seleccionado.TipoEdicion.Descripcion.ToString();
                txtActivoDet.Text = seleccionado.Activo.ToString();
            }
        }



        private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                DiscoNegocio negocio = new DiscoNegocio();
                Disco seleccionado = new Disco();

                seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                negocio.EliminarLogico(seleccionado.Id);
                Cargar();
            }
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbCampo.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Titulo":
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Contiene");
                    cmbCriterio.Items.Add("Comienza con");
                    cmbCriterio.Items.Add("Termina con");
                    cmbCriterio.SelectedIndex = 0;
                    break;
                case "Estilo":
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Pop Punk");
                    cmbCriterio.Items.Add("Pop");
                    cmbCriterio.Items.Add("Rock");
                    cmbCriterio.Items.Add("Grunge");
                    cmbCriterio.SelectedIndex = 0;

                    break;
                case "Formato":
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Vinilo");
                    cmbCriterio.Items.Add("CD");
                    cmbCriterio.Items.Add("Tape");
                    cmbCriterio.SelectedIndex = 0;
                    break;
                case "Año":
                    cmbCriterio.Items.Clear();
                    cmbCriterio.Items.Add("Igual a");
                    cmbCriterio.Items.Add("Mayor a");
                    cmbCriterio.Items.Add("Menor a");
                    cmbCriterio.SelectedIndex = 0;
                    break;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Disco seleccionado = new Disco();

            if(dgvDiscos.CurrentRow != null)
            {
                seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                frmAgregar editar = new frmAgregar(seleccionado);
                editar.ShowDialog();
                Cargar();
            }
        }

        private void txtFiltrarAvanzado_TextChanged(object sender, EventArgs e)
        {
            DiscoNegocio negocio = new DiscoNegocio();

            try
            {
                string campo = cmbCampo.SelectedItem.ToString();
                string criterio = cmbCriterio.SelectedItem.ToString(); ;
                string filtro = txtFiltrarAvanzado.Text;

                if (!string.IsNullOrEmpty(filtro))
                    dgvDiscos.DataSource = negocio.Filtrar(campo, criterio, filtro);
                else
                    Cargar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            Cargar();
        }
    }
}
