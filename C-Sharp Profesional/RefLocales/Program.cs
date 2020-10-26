using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefLocales
{
    public class Program
    {

        static int[] arreglo = { 1, 2, 3, 4, 5, 6, -1 };

        static void Main(string[] args) {

            Console.Write("Dame un valor a buscar dentro del arreglo: ");
            int Numero = Convert.ToInt32(Console.ReadLine());
            ref int valor = ref BuscaValor(Numero);

            if (valor != -1) {
                Console.WriteLine("El valor arreglo es: ", valor);
                Console.ReadKey();
            }
            else { 
                Console.Write("No se ha encontrado el valor solicitado");
                Console.ReadKey();
            }
        }

        public static ref int BuscaValor(int valor) {
            
            for (int i = 0; i < 6; i++)
            {
                if (arreglo[i] == valor)
                    return ref arreglo[i];
            }
            return ref arreglo[6]; ;
                

        }

    }
}
