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

            // Variables GLOBALES

            //string esCadena = "";
            //int numeroUno;
            //int numeroDos;

            #region Bloque 4 | Condicionales

            //Console.WriteLine ( "¿Cual es el valor de Numero Uno ?" );
            //esCadena = Console.ReadLine();
            //numeroUno = Convert.ToInt32(esCadena);

            //Console.WriteLine ( "¿Cual es el valor de Numero Dos ?" );
            //esCadena = Console.ReadLine();
            //numeroDos = Convert.ToInt32(esCadena);


            #region Condición If Anidado

            //if (numeroUno <= numeroDos) {
            //    if (numeroUno == numeroDos) {
            //        Console.WriteLine ( "Numero Uno: {0} es igual a Numero Dos: {1}", numeroUno, numeroDos );
            //        Console.ReadKey();
            //    } else {
            //        Console.WriteLine ( "Numero Uno: {0} es menor a Numero Dos: {1}", numeroUno, numeroDos );
            //        Console.ReadKey();
            //    }
            //} else {
            //    Console.WriteLine ( "Numero Uno: {0} es mayor a Numero Dos {1}", numeroUno, numeroDos );
            //    Console.ReadKey();
            //}

            #endregion

            #region Condición If Else

            //if (numeroUno < numeroDos) {
            //    Console.WriteLine( "Numero Uno: {0} es menor a Numero Dos: {1}", numeroUno, numeroDos );
            //    Console.ReadKey();
            //} else if (numeroUno == numeroDos) {
            //    Console.WriteLine( "Numero Uno: {0} es igual a Numero Dos: {1}", numeroUno, numeroDos );
            //    Console.ReadKey();
            //} else {
            //    Console.WriteLine( "Numero Uno: {0} es MENOR a Numero Dos: {1}", numeroUno, numeroDos );
            //    Console.ReadKey();
            //}

            #endregion

            #region Precedencia de Operadores

            //int esResultado = (numeroUno + numeroDos) * (numeroUno / numeroDos);

            //Console.WriteLine( "La operación da como resultado: {0}", esResultado);
            //Console.ReadKey();

            #endregion

            #region Opciones Multiples

            //switch (numeroUno) {
            //    case 1:
            //        Console.WriteLine( "Se ha escojido el caso numero 1" );
            //        break;

            //    case 2:
            //        Console.WriteLine( "Se ha escojido el caso numero 2" );
            //        break;

            //    default:
            //        Console.WriteLine( "No se ha seleccionado ningun caso" );
            //        break;
            //}
            //Console.ReadKey();

            #endregion

            #region Valores Nulables y Operador Terniario

            //int? valorX = null;
            //int valorY;
            
            ///*
            // * Aquí esta el operador terniario con sintaxis () ? :
            // */

            //string esCadenaString = valorX.HasValue ? "valorX ha devuelto como valor :{0}" + valorX.ToString() : "valorX ha devuelto un valor :{0}" ;

            //Console.WriteLine(esCadenaString);
            //Console.ReadKey();

            ///* 
            // * (??) En caso de que X tenga valor, se asgina a Y
            // * (?? -1) En caso de que X sea null se asgina un valor despues de ?? que es -1
            // */

            //valorY = valorX ?? -1; 

            //Console.WriteLine("valorY devuelve como valor: {0}", valorY );
            //Console.ReadKey();

            #endregion

            #endregion

            #region Bloque 5 | Clases y Objetos

            clsProductos Producto, SegundoProducto;

            Producto = new clsProductos();
            
            Producto.idProducto = 1;
            Producto.claveProducto = "P00001";
            Producto.descripcionProducto = "Galletas Marinela 500 grms.";
            Producto.codigoBarras = "12345678";

            SegundoProducto = new clsProductos(2, "P00002", "Donas Bimbo", "123456789" );

            Console.WriteLine( "Información del producto" );
            Console.WriteLine( "Id: {0}", Producto.idProducto );
            Console.WriteLine( "Clave: {0}", Producto.claveProducto );
            Console.WriteLine( "Descripción: " + Producto.descripcionProducto );
            Console.WriteLine( "Código de Barras: {0}", Producto.codigoBarras );

            Console.WriteLine( "Información del segundo producto" );
            Console.WriteLine("Id: {0}", SegundoProducto.idProducto);
            Console.WriteLine("Clave: {0}", SegundoProducto.claveProducto);
            Console.WriteLine("Descripción: " + SegundoProducto.descripcionProducto);
            Console.WriteLine("Código de Barras: {0}", SegundoProducto.codigoBarras);

            Console.ReadKey();

            #endregion

            #region Ejercicio 1| Suma de precios | Clase Operaciones

            //Operaciones tipoOperacion = new Operaciones();

            //Console.WriteLine( "Determina precio 1: " );
            //esCadena = Console.ReadLine();
            //numeroUno = Convert.ToInt32(esCadena);

            //Console.WriteLine( "Determina precio 2:");
            //esCadena = Console.ReadLine();
            //numeroDos = Convert.ToInt32(esCadena);

            //tipoOperacion.ObtenerValorSuma(numeroUno, numeroDos);

            //Console.WriteLine( "Al sumar el precio 1 y precio 2 se tiene un total de: {0:C} ", tipoOperacion.ImprimirSuma() );
            //Console.ReadKey();

            #endregion

            #region Ejercicio 2 | Condiciones | Bloque 4

            //string ejemploCadena = "";
            //int edadPersona = 0;

            //Console.WriteLine( "Hola, ¿cual es tu edad?" );
            //ejemploCadena = Console.ReadLine();
            //edadPersona = Convert.ToInt32(ejemploCadena);

            //if (edadPersona < 18) {
            //    Console.WriteLine( "¡Uh! No tienes edad suficiente, lo lamento :( ", edadPersona);
            //    Console.ReadKey();
            //}
            //else if (edadPersona >= 18) {
            //    Console.WriteLine("¡Genial!, ya yienes edad sufiecente, chocalas :) ", edadPersona);
            //    Console.ReadKey();
            //}

            #endregion

        }
    }
}
