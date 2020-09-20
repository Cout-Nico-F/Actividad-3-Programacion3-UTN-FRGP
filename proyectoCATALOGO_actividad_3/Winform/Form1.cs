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
        private List<Articulo> ListaOriginal; 
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
            //evita que salga seleccionado una row por defecto
            if(dgvListar.Rows.Count > 0 )
            {
                dgvListar.Rows[0].Selected = false;
            }
        }

        private void Cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            ListaOriginal = negocio.ListarArticulos();
            dgvListar.DataSource = ListaOriginal;
            dgvListar.Columns["id"].Visible = false;
            dgvListar.Columns["imagenurl"].Visible = false;
            //dgvListar.CurrentCell = null; //Para que no este seleccionado ningun articulo por defecto.
            //dgvListar.Rows[0].Selected = false;
        }

        private void dgvListar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvListar.CurrentRow != null)
                {
                    Articulo reg = (Articulo)dgvListar.CurrentRow.DataBoundItem;
                    pbImagen.Load(reg.imagenUrl);
                }
            }
            catch (System.NullReferenceException ex)
            {
                pbImagen.Image = null; //de esta manera se setea en nula la imagen para que no muestre la anterior.
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            form_Alta alta = new form_Alta();
            alta.ShowDialog();
            Cargar();
            Ocultar_Submenu();
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
            //Ocultar_Submenu();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            /*Articulo art;
            art = (Articulo)dgvListar.CurrentRow.DataBoundItem;

            form_Alta modificar = new form_Alta();
            modificar.ShowDialog();
            Cargar();*/

            if (dgvListar.CurrentRow != null)
            {
                form_Alta modificar = new form_Alta((Articulo)dgvListar.CurrentRow.DataBoundItem);
                modificar.ShowDialog();
                Cargar();
            }
            else
            {
                MessageBox.Show("Haga click sobre un articulo para seleccionarlo, luego presione modificar", "Elija el articulo a modificar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Text = "Modificar Articulos";

            Ocultar_Submenu();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgvListar.CurrentRow != null)
            {
                form_Baja baja = new form_Baja((Articulo)dgvListar.CurrentRow.DataBoundItem);
                baja.ShowDialog();
                Cargar(); // para que al volver a form1 la lista este actualizada.
            }
            else
            {
                MessageBox.Show("Haga click sobre un articulo para seleccionarlo, luego presione eliminar", "Elija el articulo a eliminar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Ocultar_Submenu();
        }

        private void btn_Opciones_Click(object sender, EventArgs e)
        {
            Mostrar_Submenu(panel_Opciones);
        }

        private void tm_timer_Tick(object sender, EventArgs e)
        {
            lbl_Hora.Text = DateTime.Now.ToLongTimeString(); //mayusculas = formato 24 horas
            lbl_Fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btn_PantallaCarga_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_Hora_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Fecha_Click(object sender, EventArgs e)
        {

        }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            // no acepta el operando || (or) con variables de tipo string
            String buscarPorNombre = "x => x.nombre.ToUpper().Contains(txt_Filtro.Text.ToUpper())";
            String buscarPorDescripcion = "x.descripcion.ToUpper().Contains(txt_Filtro.Text.ToUpper())";
            String buscarPorMarca = "x.Marca.Descripcion.ToUpper().Contains(txt_Flitro.Text.ToUpper())";
            String buscarPorCategoria = "x.Categoria.Descripcion.ToUpper().Contains(txt_Filtro.Text.ToUpper())";
            //tremendo fail lo de pasarlo a string

            List<Articulo> lista = (List<Articulo>)dgvListar.DataSource;
            List<Articulo> listaFiltrada = ListaOriginal.FindAll(x => x.nombre.ToUpper().Contains(txt_Filtro.Text.ToUpper()) || x.descripcion.ToUpper().Contains(txt_Filtro.Text.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(txt_Filtro.Text.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(txt_Filtro.Text.ToUpper()) || x.codigo.ToUpper().Contains(txt_Filtro.Text.ToUpper()) );

            //Quizas puedo agregar un boton en el form1 que diga busqueda avanzada si sobra tiempo lo hago
            
            dgvListar.DataSource = listaFiltrada;
            // Solo tenia que pasarlo a TextChanged porque en el evento keyPress funciona regular y ahora pensandolo mejor
            // tiene sentido jaja porque estaba esperando una tecla
            
        }

        private void txt_Filtro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // no acepta el operando || (or) con variables de tipo string
            /*String buscarPorNombre = "x => x.nombre.ToUpper().Contains(txt_Filtro.Text.ToUpper())";
            String buscarPorDescripcion = "x.descripcion.ToUpper().Contains(txt_Filtro.Text.ToUpper())";
            String buscarPorMarca = "x.Marca.Descripcion.ToUpper().Contains(txt_Flitro.Text.ToUpper())";
            String buscarPorCategoria = "x.Categoria.Descripcion.ToUpper().Contains(txt_Filtro.Text.ToUpper())";
            List<Articulo> lista = (List<Articulo>)dgvListar.DataSource;
            List<Articulo> listaFiltrada = ListaOriginal.FindAll(x => x.nombre.ToUpper().Contains(txt_Filtro.Text.ToUpper()) );

            // no lo probe todavia 
            dgvListar.DataSource = listaFiltrada;
            //probado pero funciona regular*/
        }
    }
}
