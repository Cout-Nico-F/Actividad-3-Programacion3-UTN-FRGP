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
    public form_Alta()
    {
      InitializeComponent();
    }
        private void Cargar()
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgv_Alta.DataSource = negocio.ListarArticulos();
            dgv_Alta.Columns["id"].Visible = false;
            dgv_Alta.Columns["imagenurl"].Visible = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            // Una cosa importante es que deben estar en orden con los textbox, deben estar tal cual estan por ejemplo si el primero es txt_Codigo
            // en el form de Alta tengo que hacer un if de Codigo primero porque si no no tira el error en orden

            ComprobarCampos();

            Articulo nuevo = new Articulo();
            Marca marca = new Marca();
            Categoria categoria = new Categoria();
            ArticulosNegocio articuloNegocio = new ArticulosNegocio();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            nuevo.codigo = txt_Codigo.Text;
            nuevo.nombre = txt_Nombre.Text;
            nuevo.descripcion = txt_Descripcion.Text;
            nuevo.precio = Convert.ToDecimal(txt_Precio.Text); 
            marca =(Marca)combob_Marca.SelectedItem;
            categoria = (Categoria)combob_Categoria.SelectedItem;
            nuevo.imagenUrl = txt_ImagenURL.Text;

            //funcion de agregar articulo
            articuloNegocio.agregarArticulo(nuevo,marca,categoria);
            //marcaNegocio.agregarMarca(marca);
            //categoriaNegocio.agregarCategoria(categoria);

            //MessageBox.Show("Articulo agregado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            //con este nuevo form de Alta no haria falta el mensaje no? ya que el dgv se actualiza automaticamente

            form_Alta alta= new form_Alta();
            alta.ShowDialog();
            Cargar();
            //Close();
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
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComprobarCampos()
        {
            if (txt_Codigo.Text == "")
            {
                errorAlta.SetError(txt_Codigo, "Codigo no ingresado");
                MessageBox.Show("Ingrese el codigo del Articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Codigo.Focus();
                return;
            }
            errorAlta.SetError(txt_Codigo, "");

            if (txt_Nombre.Text == "")
            {
                errorAlta.SetError(txt_Nombre, "Nombre no ingresado");
                MessageBox.Show("Ingrese el nombre del Articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Nombre.Focus();
                return;
            }
            errorAlta.SetError(txt_Nombre, "");

            if (txt_Descripcion.Text == "")
            {
                errorAlta.SetError(txt_Descripcion, "Descripcion no ingresado");
                MessageBox.Show("Ingrese un descripcion del Articulo", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_Descripcion.Focus();
                return;
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
                return;
            }
            errorAlta.SetError(txt_Precio, "");

            if (combob_Marca.Text == "")
            {
                errorAlta.SetError(combob_Marca, "Marca no ingresada");
                MessageBox.Show("Elija una Marca de la lista desplegable", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                combob_Marca.Focus();
                return;
            }
            errorAlta.SetError(combob_Marca, "");

            if (combob_Categoria.Text == "")
            {
                errorAlta.SetError(combob_Categoria, "Categoria no ingresada");
                MessageBox.Show("Elija una categoria del la lista desplegable", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                combob_Categoria.Focus();
                return;
            }
            errorAlta.SetError(combob_Categoria, "");
        }

        private void dgv_Alta_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
