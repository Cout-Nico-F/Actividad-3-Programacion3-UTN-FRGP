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
    public partial class form_Alta : Form
    {
        private Articulo articulo = null;

        public form_Alta()
        {
            InitializeComponent();
        }

        public form_Alta(Articulo _articulo)
        {
            InitializeComponent();
            articulo = _articulo;
        }

        private void Cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgv_Alta.DataSource = negocio.ListarArticulos();
            dgv_Alta.Columns["id"].Visible = false;
            dgv_Alta.Columns["imagenurl"].Visible = false;
        }
        public void Limpiar_txt_cb()
        {
            txt_Codigo.Clear();
            txt_Descripcion.Clear();
            txt_ImagenURL.Clear();
            txt_Nombre.Clear();
            txt_Precio.Clear();

            // no encontre una forma de que se limpien los combobox porque siempre aparece como predeterminado samsung y celulares
            // encontre una manera pero nose si es la adecuada de todos modos dejo el comentario por ahi si encontras una manera mas limpia 

            combob_Categoria.Text = " ";
            combob_Marca.Text = " ";
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (ComprobarCampos())
            {
                Articulo articulo = new Articulo();

                Marca marca = new Marca();
                Categoria categoria = new Categoria();
                ArticulosNegocio articuloNegocio = new ArticulosNegocio();
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                articulo.codigo = txt_Codigo.Text;
                articulo.nombre = txt_Nombre.Text;
                articulo.descripcion = txt_Descripcion.Text;
                articulo.precio = Convert.ToDecimal(txt_Precio.Text);
                marca = (Marca)combob_Marca.SelectedItem;
                categoria = (Categoria)combob_Categoria.SelectedItem;
                articulo.imagenUrl = txt_ImagenURL.Text;

                articuloNegocio.agregarArticulo(articulo, marca, categoria);

                Cargar();
                Limpiar_txt_cb();
            }
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
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgv_Alta.DataSource = negocio.ListarArticulos();
            dgv_Alta.Columns[4].Visible = false;

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            combob_Marca.DataSource = marcaNegocio.ListarMarcas();
            combob_Categoria.DataSource = categoriaNegocio.ListarCategorias();

            combob_Categoria.ValueMember = "Id";
            combob_Categoria.DisplayMember = "Descripcion";

            combob_Marca.ValueMember = "Id";
            combob_Marca.DisplayMember = "Descripcion";

            Limpiar_txt_cb();

            if (articulo != null)
            {
                txt_Nombre.Text = articulo.nombre;
                txt_Descripcion.Text = articulo.descripcion;
                txt_Codigo.Text = articulo.codigo;
                txt_ImagenURL.Text = articulo.imagenUrl;
                txt_Precio.Text = articulo.precio.ToString();

                combob_Categoria.SelectedValue = articulo.Categoria.Id;
                combob_Marca.SelectedValue = articulo.Marca.Id;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ComprobarCampos() //Todos los campos menos el ID admiten null en la base de datos. entonces de que sirve este metodo en realidad? 
        {
            /*if (txt_Codigo.Text == "")
            {
                errorAlta.SetError(txt_Codigo, "Codigo no ingresado");
                MessageBox.Show("Ingrese el codigo del Articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Codigo.Focus();
                return false;
            }
            errorAlta.SetError(txt_Codigo, "");

            if (txt_Nombre.Text == "")
            {
                errorAlta.SetError(txt_Nombre, "Nombre no ingresado");
                MessageBox.Show("Ingrese el nombre del Articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Nombre.Focus();
                return false;
            }
            errorAlta.SetError(txt_Nombre, "");

            if (txt_Descripcion.Text == "")
            {
                errorAlta.SetError(txt_Descripcion, "Descripcion no ingresado");
                MessageBox.Show("Ingrese un descripcion del Articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Descripcion.Focus();
                return false;
            }
            errorAlta.SetError(txt_Descripcion, "");

            // Ejemplo para hacer que el textbox solo acepte numeros
            //if(!int.TryParse(txtEdad.Text,out Edad))
            Decimal Precio;

            if (!Decimal.TryParse(txt_Precio.Text, out Precio))
            {
                // no sabia que poner en el mensaje de error xD
                errorAlta.SetError(txt_Precio, "Precio no ingresado o el Precio no es un numero");
                MessageBox.Show("Ingrese un Precio expresado de forma numerica ", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Precio.Focus();
                return false;
            }
            errorAlta.SetError(txt_Precio, "");

            if (combob_Marca.Text == "")
            {
                errorAlta.SetError(combob_Marca, "Marca no ingresada");
                MessageBox.Show("Elija una Marca de la lista desplegable", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                combob_Marca.Focus();
                return false;
            }
            errorAlta.SetError(combob_Marca, "");

            if (combob_Categoria.Text == "")
            {
                errorAlta.SetError(combob_Categoria, "Categoria no ingresada");
                MessageBox.Show("Elija una categoria del la lista desplegable", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                combob_Categoria.Focus();
                return false;
            }
            errorAlta.SetError(combob_Categoria, "");
*/
            return true;
        }

        private void btn_Volver_Agregar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
