using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Montar_objeto_Artigo___DITEC_Ajuda.Builder.Base;
namespace Montar_objeto_Artigo___DITEC_Ajuda.Builder
{
    class ArtigoVazioBuilder : IArtigoVazio
    {
        public string titulo { get; set; }
        public string corpo { get; set; }

        public void inserirCorpo()
        {
            this.corpo = "Corpo vazio";
        }

        public void inserirTitulo()
        {
            this.titulo = "Titulo vazio";
        }

        
    }
}
