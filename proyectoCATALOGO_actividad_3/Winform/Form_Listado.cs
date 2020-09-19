using Modelo;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form_Listado : Form
    {
        public Form_Listado()
        {
            InitializeComponent();
        }
        private void Form_Listado_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgv_Listado.DataSource = negocio.ListarArticulos();
            dgv_Listado.Columns[4].Visible = false;
        }

        private void dgvListar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo = (Articulo)dgv_Listado.CurrentRow.DataBoundItem;
                pb_Imagen.Load(articulo.imagenUrl);
            }
            catch (Exception)
            {

                pb_Imagen.Image = null;
            }
        }

        private void btn_VolverListado_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbl_Hora2_Click(object sender, EventArgs e)
        {

        }

        private void tm_time_Tick(object sender, EventArgs e)
        {
            lbl_Hora2.Text = DateTime.Now.ToString("hh:mm:ss"); //mayusculas = formato 24 horas
            lbl_Fecha2.Text = DateTime.Now.ToShortDateString();
        }
    }
}
