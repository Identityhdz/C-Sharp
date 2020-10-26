using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaPedidos
{
    public static class ControlPedidos
    {

        #region Propiedades
        public static Productos Producto = new Productos();
        public static Clientes Clientes = new Clientes();
        public static Pedidos Pedido = new Pedidos();
        #endregion

        #region Metodos
        public static void CrearPedido() {

        }

        public static void SeleccionarCliente() {
            ColeccionClientes objclientes = new ColeccionClientes();
            Console.WriteLine("Inicio de nombre de cliente: ");
            string cadenaDatosCliente = Console.ReadLine();
            Clientes cliente = objclientes.ObtenerPorNombre(cadenaDatosCliente);
            if (cliente != null)
            {
                Console.WriteLine("El nombre del cliente es: " + cliente.NombreCompleto + " con clave " + cliente.Clave + " .");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("No se encontro un cliente con el nombre definido");
                Console.ReadKey();
            }
        }


        public static void AgregarProductoPedido() {

            Productos productos;
            productos = new Productos();

            productos.Precio = 100;
            productos.PorcentajeIva = 16;
            productos.Ieps = 2m; // 0.02
            productos.EsMontoIEPS = false ; // true

            decimal PrecioSinIvaIEPS; // ref
            decimal MontoIeps = productos.DesglosaIeps(out PrecioSinIvaIEPS); // ref

            Console.WriteLine("El precio del pedido sin iva es: " + productos.PrecioSinIva());

            Console.WriteLine("El resultado sin iva sin ieps es: {0} " + " y el ieps es de: {1} ", PrecioSinIvaIEPS, MontoIeps);
            Console.ReadKey();

        }

        public static void EliminarProductoPedido() { 
        
        
        }

        public static string MostrarPedido() {
            return "";
        }
        #endregion

    }
}
