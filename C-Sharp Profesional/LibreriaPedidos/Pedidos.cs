using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPedidos
{
    // Clase que contiene un Objeto
    public partial class Pedidos
    {

        #region Properties 
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public decimal SubTotal { get; set; }
        public decimal MontoIva { get; set; }
        public decimal Total { get; set; }
        public Clientes Cliente { get; set; }
        #endregion

        #region Methods
        public Pedidos () {
            Cliente = new Clientes();
        }
        #endregion

    }
}
