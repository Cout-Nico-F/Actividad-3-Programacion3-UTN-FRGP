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
  public partial class form_Alta : Form
  {
    public form_Alta()
    {
      InitializeComponent();
    }

        private void btAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            btAceptar.Cursor = Cursors.Hand;
        }

        private void btCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            btCancelar.Cursor = Cursors.Hand;
        }

        private void form_Alta_Load(object sender, EventArgs e)
        {
            if(txt_Codigo.Text == "")
            {
                
            }
        }
    }
}
