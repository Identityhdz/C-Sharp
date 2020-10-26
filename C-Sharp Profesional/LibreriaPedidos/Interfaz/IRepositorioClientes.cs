using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPedidos
{
    interface IRepositorioClientes
    {
        /* Se crea ibterfaz, se definen metodos sin cuerpo donde se reciven parametros para manejar Colleccion de clientes.
         * 
         */

        void ObtenerClientes(ref Clientes [] clientes);
        void ObtenerCliente(ColeccionClientes cliente);
        void CrearCliente(ColeccionClientes cliente);
        void ModificarCliente(ColeccionClientes cliente);
        void EliminarCliente(ColeccionClientes cliente);

    }
}
