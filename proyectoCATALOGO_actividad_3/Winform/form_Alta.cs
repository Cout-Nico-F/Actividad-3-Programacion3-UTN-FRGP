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

            //funcion de agregar articulo
            articuloNegocio.agregarArticulo(nuevo,marca,categoria);
            //marcaNegocio.agregarMarca(marca);
            //categoriaNegocio.agregarCategoria(categoria);

            MessageBox.Show("Articulo agregado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
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
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            combob_Marca.DataSource = marcaNegocio.ListarMarcas();
            combob_Categoria.DataSource = categoriaNegocio.ListarCategorias();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Codigo_TextChanged(object sender, EventArgs e)
        {
            txt_Codigo.MaxLength = 50;
        }

        private void txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            txt_Nombre.MaxLength = 50;
        }

        private void txt_Descripcion_TextChanged(object sender, EventArgs e)
        {
            txt_Descripcion.MaxLength = 150;
        }

        private void txt_Precio_TextChanged(object sender, EventArgs e)
        {
            txt_Precio.MaxLength = 10;
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
    }
}
