using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaProductos
{
    public class clsProductos
    {

        #region Propiedades 
        public int idProducto { get; set; }
        public string claveProducto { get; set; }
        public string descripcionProducto { get; set; }
        public string codigoBarras { get; set; }
        #endregion

        #region Constructores 
        public clsProductos() { 
           // Constructor Vacio
        }

        public clsProductos(int Id, string Clave, string Descripcion, string CodigoBarras) {

            idProducto = Id;
            claveProducto = Clave;
            descripcionProducto = Descripcion;
            codigoBarras = CodigoBarras;

        }

        #endregion

        #region Metodos
        #endregion

    }
}
