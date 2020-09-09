using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  class Articulo
  {
    private int id;
    private string codigo;
    private string descripcion;
    private string marca;
    private string categoria;
    // por ahora creo los atributos privados porque no tengo claro cuales van a necesitar tener getter y/o setters todavia.
    // despues mientras vallamos necesitando escribirlos o leerlos les hacemos las props
    //Dejo aca tambien la linea que nos va a permitir que ande en las 2 pc ya que tenemos el mismo nombre de base de datos (sera parte del Negocio)
    // conexion.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
  }
}
