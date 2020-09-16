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
    public partial class form_Baja : Form
    {
        private DataGridViewSelectedRowCollection _articuloSeleccionado;
        public form_Baja()
        {
            InitializeComponent();
        }

        public form_Baja(DataGridViewSelectedRowCollection articuloSeleccionado)
        {
            _articuloSeleccionado = articuloSeleccionado;
            InitializeComponent();
        }

        private void form_Baja_Load(object sender, EventArgs e)
        {
            dgv_Baja.DataSource = _articuloSeleccionado;
        }
    }
}
