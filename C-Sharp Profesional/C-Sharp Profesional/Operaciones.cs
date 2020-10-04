using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Profesional
{
    class Operaciones
    {

        // Variables de operaciones
        private int Suma;

        #region Suma de dos valores
        public void ObtenerValorSuma(int Numero_Int, int Numero_Int2)
        {
            Suma = Numero_Int + Numero_Int2;
        }

        public int ImprimirSuma()
        {
            return Suma;
        }
        #endregion
    }
}
