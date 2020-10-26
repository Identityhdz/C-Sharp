using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LibreriaPedidos
{
    class clsRepositorioClientes : IRepositorioClientes
    {

        #region Metodos 
        public void CrearCliente(ColeccionClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void EliminarCliente(ColeccionClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ModificarCliente(ColeccionClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenerCliente(ColeccionClientes cliente)
        {
            //throw new NotImplementedException();
        }

        public void ObtenerClientes(ref Clientes[] clientes)
        {
            //throw new notimplementedexception();
            clientes = new Clientes[] {
                    new Clientes { IdCliente = 1, Clave = "c0001", NombreCompleto = "igmar jovan hernandez martinez ", RFC = "hemi", Tipo = TipoCliente.Publico},
                    new Clientes { IdCliente = 2, Clave = "0002", NombreCompleto = "patricio hernandez martinez ", RFC = "hepa", Tipo = TipoCliente.Medio},
                    new Clientes { IdCliente = 3, Clave = "0003", NombreCompleto = "marco hernandez martinez ", RFC = "hema", Tipo = TipoCliente.Medio },
                    new Clientes { IdCliente = 4, Clave = "0004", NombreCompleto = "luis hernandez martinez ", RFC = "helu", Tipo = TipoCliente.Mayoreo },
                    /*convercion explicita de para el tipo, acedemos al valor enum (int) por convercion */
                    new Clientes { IdCliente = 5, Clave = "0005", NombreCompleto = "angel hernandez martinez ", RFC = "hean", Tipo = (TipoCliente) 2 }
            };

            //clientes[0] = new Clientes { IdCliente = 1, Clave = "C0001", NombreCompleto = "Igmar Jovan Hernandez Martinez ", RFC = "HEMI", Tipo = TipoCliente.Publico };
            //clientes[1] = new Clientes { IdCliente = 2, Clave = "0002", NombreCompleto = "Patricio Hernandez Martinez ", RFC = "HEPA", Tipo = TipoCliente.Medio };
            //clientes[2] = new Clientes { IdCliente = 3, Clave = "0003", NombreCompleto = "Marco Hernandez Martinez ", RFC = "HEMA", Tipo = TipoCliente.Mayoreo };
            //clientes[3] = new Clientes { IdCliente = 4, Clave = "0004", NombreCompleto = "Luis Hernandez Martinez ", RFC = "HELU", Tipo = TipoCliente.Medio };
        }
        #endregion
    }
}
