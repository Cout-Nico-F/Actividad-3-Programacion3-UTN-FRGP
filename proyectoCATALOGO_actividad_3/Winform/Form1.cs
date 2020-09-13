﻿using System;
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
    }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            dgvListar.DataSource = negocio.ListarArticulos();
            dgvListar.Columns[3].Visible = false;
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

                
            }
            
           
        }
    }
}