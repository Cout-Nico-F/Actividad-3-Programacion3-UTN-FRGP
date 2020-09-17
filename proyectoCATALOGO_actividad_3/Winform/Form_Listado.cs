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
            Articulo articulo = (Articulo)dgv_Listado.CurrentRow.DataBoundItem;
            pb_Imagen.Load(articulo.imagenUrl);
        }
    }
}
