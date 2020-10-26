using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPedidos
{
    class ColeccionClientes
    {
        #region PropiedadClientes
        public Clientes [] Items { get; set; }
        #endregion

        #region Constructor
        public ColeccionClientes() 
        {
            clsRepositorioClientes repo = new clsRepositorioClientes();
            Clientes [] intermedio  = new Clientes[4];

            repo.ObtenerClientes(ref intermedio);
            Items = intermedio;

        }
        #endregion


        #region Metodos
        public Clientes ObtenerPorNombre (string Nombre) 
        {
            Clientes returnCliente = null;

            for (int i = 0; i < 4; i++)
            {
                if (Items[i].NombreCompleto.StartsWith(Nombre))
                {
                    returnCliente = Items[i];
                    break;
                }
            }

            return returnCliente;
        }
        #endregion
    }
}
