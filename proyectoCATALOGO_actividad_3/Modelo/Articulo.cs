using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
  public class Articulo
  {
    public int Id { get; set; }
  
    public string codigo { get; set; }
   
    public string nombre { get; set; }

    public string descripcion { get; set; }
        
    public string imagenUrl { get; set; }

    public Decimal precio { get; set; }

    public Marca Marca { get; set; }

    public Categoria Categoria { get; set; }
  }
}
