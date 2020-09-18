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
    //problema de asignacion de id salta del ID = 5 al ID = 11
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
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Articulos_Click(object sender, EventArgs e)
        {
            Mostrar_Submenu(panel_Productos);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_Listado listado = new Form_Listado();
            listado.ShowDialog();
            Cargar();
            Ocultar_Submenu();
            
            // me confundi de nombre nose como arreglarlo
            // codigo

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
            Ocultar_Submenu();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvListar.SelectedRows.Count == 1)
            {
                form_Baja baja = new form_Baja((Articulo)dgvListar.CurrentRow.DataBoundItem);
                baja.ShowDialog();
                Cargar(); // para que al volver a form1 la lista este actualizada.
            }
            else
            {
                MessageBox.Show("Haga click sobre un articulo para eliminarlo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // nose que te parece esto hice no visible el cuadrito del costado (Row) y en cambio hice que se pueda seleccionar toda la fila de una ¿Que te parece?
                //MessageBox.Show("Haga click en la zona blanca del articulo a eliminar para seleccionarlo \n(La fila entera aparecera seleccionada) ", "Seleccione primero la fila a Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ocultar_Submenu();
        }

        private void btn_Opciones_Click(object sender, EventArgs e)
        {
            Mostrar_Submenu(panel_Opciones);
        }

        private void pbImagen_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvListar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListar_SelectionChanged_1(object sender, EventArgs e)
        {

        }
    }
}
