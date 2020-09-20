using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    public partial class Form_Bienvenida : Form
    {
        public Form_Bienvenida()
        {
            InitializeComponent();
        }


        private void tm_1_Tick(object sender, EventArgs e)
        {
            

            if (this.Opacity < 1)
            {
                this.Opacity += 1;
            } 
            pb_Carga.Value += 1;
            lbl_Carga.Text = pb_Carga.Value + "%";
            // Hace un espera entre estos intervalos 
            // 31 es 30
            if(pb_Carga.Value  == 31 ) { Thread.Sleep(1000); }
            if (pb_Carga.Value == 51) { Thread.Sleep(3000); }
            if (pb_Carga.Value == 81) { Thread.Sleep(2000); }
            if (pb_Carga.Value == 100) { Thread.Sleep(4000); }

            //era un poco molesto a la hora de compilar por eso lo comente a la hora de entregar deberia descomentar los if
            //Ahora si duro poco comentado 
            if (pb_Carga.Value == 100)
            {
                tm_1.Stop();
                tm_2.Start();
            }
           

        }

        private void tm_2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 1;
            if(this.Opacity == 0)
            {
                tm_2.Stop();
                //this.Close();
            }
            Form1 f = new Form1();
            f.ShowDialog();
            
        }

        private void Form_Bienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            tm_1.Start();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
