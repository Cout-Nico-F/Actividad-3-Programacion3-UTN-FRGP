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
    public partial class form_CargaAplicacion : Form
    {
        public form_CargaAplicacion()
        {
            InitializeComponent();
        }

        private void tm_PantallaCarga_Tick(object sender, EventArgs e)
        {
            if (pb_Carga.Value < 100)
            {
                pb_Carga.Value = pb_Carga.Value + 10;
                lbl_Carga.Text = "Cargand el sistema al " + pb_Carga.Value + " %";
            }
            else
            {
                tm_PantallaCarga.Enabled = false;
                this.Hide();
                Form_Listado listado = new Form_Listado();
                listado.ShowDialog();

            }

           
               
        }

        private async void form_CargaAplicacion_Load(object sender, EventArgs e) // async es asincrono
        {
            Task tarea = new Task(Tiempo_Carga);
            tarea.Start();



            await tarea;

            Form_Listado listado = new Form_Listado();
            listado.ShowDialog();
        }

        private void Tiempo_Carga()
        {
            Thread.Sleep(3000);
        }
        private  void Mostrar()
        {

        }
        private void Cerrar()
        {

        }
    }
}
