using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  public class Articulo
  {
    private int id;
        //private string codigo;
        public string codigo { get; set; }
        //private string descripcion;
        public string descripcion { get; set; }
        public string nombre { get; set; }

        public string imagenUrl { get; set; }

        public Decimal precio { get; set; }

        private string marca;
    private string categoria;
    // por ahora creo los atributos privados porque no tengo claro cuales van a necesitar tener getter y/o setters todavia.
    // despues mientras vallamos necesitando escribirlos o leerlos les hacemos las props
    //Dejo aca tambien la linea que nos va a permitir que ande en las 2 pc ya que tenemos el mismo nombre de base de datos (sera parte del Negocio)
    // conexion.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
    // Defini la clase Articulo como public para que pueda ser usada por la clase winform mas adelante
  }
}
