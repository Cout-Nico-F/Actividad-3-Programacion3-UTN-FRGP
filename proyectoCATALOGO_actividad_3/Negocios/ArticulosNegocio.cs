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
            List<Articulo> listaArticulos = new List<Articulo>(); //Refactorizé el nombre de Table a listaArticulos

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "select a.codigo As Codigo, a.nombre As Nombre, a.descripcion As Descripcion, a.imagenUrl, a.precio, m.descripcion as Marca , c.descripcion as Categoria from articulos a left join categorias c on a.idcategoria = c.id inner join marcas m on a.idmarca = m.id";
            command.Connection = connection;
            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read()) // va a recorrer cada registro y va dejar el puntero en el proximo registro
            {
                Articulo aux = new Articulo();
                aux.codigo = Reader.GetString(0);
                aux.nombre = Reader.GetString(1);
                aux.descripcion = Reader.GetString(2);
                aux.precio = Reader.GetDecimal(4);
                // hice un try y catch de aux.ImagenUrL porque me tiraba error ya que el alta de un articulo no da la posibilidad de ingresar una url
                // por ahora queda asi
                try
                {
                    aux.imagenUrl = Reader.GetString(3);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {

                    aux.imagenUrl = " No contiene una Direccion URL";
                }
                try
                {
                  aux.Marca = new Marca();
                  aux.Marca.Descripcion = (string)Reader.GetString(5);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                  aux.Marca.Descripcion = " ";
                }

                try
                {
                  aux.Categoria = new Categoria();
                  aux.Categoria.Descripcion = (string)Reader.GetString(6);
                }

                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                  aux.Categoria.Descripcion = " ";
                }
                

                // (tengo problemas con mostrar el precio) rta-> Segun lo que investigué el tipo de data Money de SQL es equivalente al tipo Decimal en .net
                
                // (no se porque sale descripcion antes que nombre) rta-> DGV toma por defecto el orden de la clase Articulo en este caso.  Entonces cambié el orden de declaracion de las prop y listo.

                listaArticulos.Add(aux);
            }

            connection.Close();
            return listaArticulos;

        }

        public void agregarArticulo(Articulo nuevo,Marca m,Categoria c)
        {
            // Maxi nos va a ayudar a optimizar esto mas adelante pero por ahora asi funciona
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into ARTICULOS(Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria) values ('" + nuevo.codigo + "','" + nuevo.nombre + "','" + nuevo.descripcion + "','" + nuevo.precio + "','"+ m.Id +"','"+ c.Id + "')"; ;
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void bajaArticulo(Articulo nuevo)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "";
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
        }
        
        
    }
    // Tambien cree una biblioteca de clase llamada ArticulosNegocio, ademas referencie Modelo con Negocios para poder hacer un using Modelo
}
