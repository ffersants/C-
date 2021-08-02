using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___Agora_vai
{
    interface IBuilder
    {
        public void setarTitulo();
        Artigo pegarResultado();
    }
}
