using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Profesional
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables Globales
            string Cadena = "";
            int Numero_1;
            int Numero_2;

            #region Bloque 4 | Condicionales

            Console.WriteLine("Define Valor 1 : ");
            Cadena = Console.ReadLine();
            Numero_1 = Convert.ToInt32(Cadena);

            Console.WriteLine("Define Valor 2 : ");
            Cadena = Console.ReadLine();
            Numero_2 = Convert.ToInt32(Cadena);


            if (Numero_1 <= Numero_2) {
                Console.WriteLine("El valor 1: {0} es menor o igual al Valor 2: {1}", Numero_1, Numero_2);
            }
            else {
                Console.WriteLine("El Valor 2: {1} es mayor al Valor 1: {0}", Numero_1, Numero_2);
                Console.ReadKey();
            }

            #endregion

            #region Ejercicio 1| Suma de precios | Clase Operaciones
            //Operaciones Operando = new Operaciones();

            //Console.WriteLine("Define el Precio 1 $");
            //Cadena = Console.ReadLine();
            //Numero_1 = Convert.ToInt32(Cadena);

            //Console.WriteLine("Define el Precio 2 $");
            //Cadena = Console.ReadLine();
            //Numero_2 = Convert.ToInt32(Cadena);

            //Operando.ObtenerValorSuma(Numero_1, Numero_2);

            //Console.WriteLine("La sumatoria de los precios es de: {0:C}", Operando.ImprimirSuma());
            //Console.ReadKey();

            #endregion


        }
    }
}
