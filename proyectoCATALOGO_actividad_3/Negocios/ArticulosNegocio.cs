using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Negocios
{
    public class ArticulosNegocio
    {
        public List<Articulo> ListarArticulos()
        {
            // Puse los nombres en ingles la verdad nose porque 
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader Reader;
            List<Articulo> lista = new List<Articulo>();

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select Codigo,Nombre,Descripcion,ImagenUrl,Precio from ARTICULOS";
            command.Connection = connection;

            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read()) // va a recorrer cada registro y va dejar el puntero en el proximo registro
            {
                Articulo aux = new Articulo();
                aux.codigo = Reader.GetString(0);
                aux.nombre = Reader.GetString(1);
                aux.descripcion = Reader.GetString(2);
                aux.imagenUrl = Reader.GetString(3);
                aux.precio = Reader.GetDecimal(4);

                // (tengo problemas con mostrar el precio) rta-> Segun lo que investigué el tipo de data Money de SQL es equivalente al tipo Decimal en .net
                 

                // (no se porque sale descripcion antes que nombre) rta-> DGV toma por defecto el orden de la clase Articulo en este caso.  Entonces cambié el orden de declaracion de las prop y listo.

                lista.Add(aux);
            }

            connection.Close();
            return lista;

        }
    }
    // Tambien cree una biblioteca de clase llamada ArticulosNegocio, ademas referencie Modelo con Negocios para poder hacer un using Modelo
}
