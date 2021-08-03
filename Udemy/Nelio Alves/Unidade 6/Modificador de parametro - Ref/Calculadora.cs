using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificado_de_parametro___Ref
{
    class Calculadora
    {
        public static void Triple(ref int multiplicado)
        {
            multiplicado = multiplicado * 3;
        }
    }
}
