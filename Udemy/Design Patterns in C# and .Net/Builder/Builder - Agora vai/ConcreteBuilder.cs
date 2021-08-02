using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder___Agora_vai
{
    class ConcreteBuilder : IBuilder 
    {
        Artigo result = new Artigo();

        public void setarTitulo()
        {
            result.titulo = "isso eh um titulo";
        }

        public Artigo pegarResultado()
        {
            return this.result;
        }
    }
}
