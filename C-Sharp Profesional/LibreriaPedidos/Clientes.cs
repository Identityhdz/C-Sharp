using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPedidos
{
    public class Clientes : clsAbstractPersonas
    {

        #region Properties 
        public int IdCliente { get; set; }
        public string Clave { get; set; }
        public string RFC { get; set; }
        public TipoCliente Tipo { get; set; }
        #endregion

        #region Constructors
        public Clientes() {


        }

        public Clientes(string nombreCompleto, string clave, string rfc) {
            NombreCompleto = nombreCompleto;
            Clave = clave;
            RFC = rfc;
        }
        #endregion

    }
}
