using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPedidos
{
    public class Productos : clsAbstractProductos
    {
        #region Properties
        public string CodigoBarras { get; set; }
        public decimal Precio { get; set; }
        public decimal PorcentajeIva { get; set; }

        public decimal Ieps { get; set; }
        public bool EsMontoIEPS { get; set; }

        #endregion

        #region Constructors

        // Constructor sin parametros
        public Productos() { 
        
        }


        // Constructor con parametros
        public Productos(int id, int clave, string descripcion, string codigoBarras, decimal precio, decimal porcentajeIva) {
            
            idProducto = id;
            Clave = clave;
            Descripcion = descripcion;
            CodigoBarras = codigoBarras;
            Precio = precio;
            PorcentajeIva = porcentajeIva;

        }
        #endregion

        #region Methods 

        public decimal DesglosaIva() {
            return Math.Round((Precio / (1 + PorcentajeIva / 100)) * PorcentajeIva / 100);
        
        }

        public virtual decimal PrecioSinIva() {

            return Math.Round(Precio / (1 + PorcentajeIva / 100), 2);
        }

        public decimal DesglosaIeps(out decimal PrecioSinIvaIEPS) { // ref

            decimal PrecioSinIva = Precio / (1 + PorcentajeIva / 100);
            decimal MontoIEPS = 0m;
            PrecioSinIvaIEPS = 0m;

            if (EsMontoIEPS)
            {
                MontoIEPS = Ieps;
                PrecioSinIvaIEPS = Math.Round(PrecioSinIva - MontoIEPS, 2);
            }
            else {
                PrecioSinIvaIEPS = Math.Round(PrecioSinIva / (1 + Ieps / 100),2);
                MontoIEPS = Math.Round(PrecioSinIvaIEPS * Ieps / 100, 2);

            }
            return MontoIEPS;

        }

        #endregion

    }
}
