using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Modelo;

// agregue como referencia a Modelo y Negocio para poder hacer un using 
namespace Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Personalizar_Disenio();
        }

        private void Personalizar_Disenio()
        {
            
            panel_Productos.Visible = false;
            panel_Opciones.Visible = false;
        }

        private void Ocultar_Submenu()
        {
            if (panel_Productos.Visible == true)
            {
                panel_Productos.Visible = false;
            } 
            if(panel_Opciones.Visible == true)
            {
                panel_Opciones.Visible = false;
            }    
        }

        private void Mostrar_Submenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                Ocultar_Submenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgvListar.DataSource = negocio.ListarArticulos();
            dgvListar.Columns["id"].Visible = false;
            dgvListar.Columns["imagenurl"].Visible = false;
            dgvListar.CurrentCell = null; //Para que no este seleccionado ningun articulo por defecto.
            dgvListar.Rows[0].Selected = false;
        }

        private void dgvListar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo reg = (Articulo)dgvListar.CurrentRow.DataBoundItem;
                pbImagen.Load(reg.imagenUrl);
            }
            catch (Exception)
            {
                // MessageBox.Show("No se encontro la imagen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); [Creo que es mejor sin error, que opinas?] rta -> Si me parece mejor de esa manera
                // no encuentro la manera de que no se muestre la imagen anterior cuando hacemos click en la imagen que no tiene url
                pbImagen.Image = null; //de esta manera se setea en nula la imagen para que no muestre la anterior.
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            form_Alta alta = new form_Alta();
            alta.ShowDialog();
            Cargar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count == 1)
            {
                form_Baja baja = new form_Baja((Articulo)dgvListar.CurrentRow.DataBoundItem);
                baja.ShowDialog();
                Cargar(); // para que al volver a form1 la lista este actualizada.
            }
            else
            {
                MessageBox.Show("Haga click sobre un articulo para eliminarlo","Informacion",MessageBoxButtons.OK,MessageBoxIcon.Information);
                // nose que te parece esto hice no visible el cuadrito del costado (Row) y en cambio hice que se pueda seleccionar toda la fila de una ¿Que te parece?
                //MessageBox.Show("Haga click en la zona blanca del articulo a eliminar para seleccionarlo \n(La fila entera aparecera seleccionada) ", "Seleccione primero la fila a Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Articulos_Click(object sender, EventArgs e)
        {
            Mostrar_Submenu(panel_Productos);
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            Form_Listado listado = new Form_Listado();
            listado.ShowDialog();
            Cargar();
            Ocultar_Submenu();
            //codigo
            Ocultar_Submenu();
        }
     
        private void btnAgrega_Click(object sender, EventArgs e)
        {
            form_Alta alta = new form_Alta();
            alta.ShowDialog();
            Cargar();
            Ocultar_Submenu();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            form_Modificar Modificar = new form_Modificar();
            Modificar.ShowDialog();
            Ocultar_Submenu();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count == 1 && dgvListar.CurrentRow != null)
            {
                form_Baja baja = new form_Baja((Articulo)dgvListar.CurrentRow.DataBoundItem);
                baja.ShowDialog();
                Cargar(); // para que al volver a form1 la lista este actualizada.
            }
            else
            {
                MessageBox.Show("Haga click sobre un articulo para seleccionarlo, luego presione eliminar", "Elija el articulo a eliminar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // nose que te parece esto hice no visible el cuadrito del costado (Row) y en cambio hice que se pueda seleccionar toda la fila de una ¿Que te parece?
            }
            Ocultar_Submenu();
        }

        private void btn_Opciones_Click(object sender, EventArgs e)
        {
            Mostrar_Submenu(panel_Opciones);
        }

        private void tm_timer_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToString("HH:mm:ss"); //mayusculas = formato 24 horas
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_Carga_Click(object sender, EventArgs e)
        {
            form_CargaAplicacion carga = new form_CargaAplicacion();
            carga.Show();
        }
    }
}
