using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Montar_objeto_Artigo___DITEC_Ajuda.Builder.Base;
namespace Montar_objeto_Artigo___DITEC_Ajuda.Director
{
    class DirectorService
    {
        public IArtigoVazio Builder { get; set; }
        public DirectorService(IArtigoVazio builder)
        {
            this.Builder = builder;
        }

        public void artigoVazio()
        {
            Builder.inserirCorpo();
            Builder.inserirTitulo();
        }
    }
}
